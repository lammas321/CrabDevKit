using BepInEx;
using BepInEx.IL2CPP.Hook;
using BepInEx.Preloader.Core.Patching;
using HarmonyLib;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using MonoOpCodes = Mono.Cecil.Cil.OpCodes;
using SystemOpCodes = System.Reflection.Emit.OpCodes;

namespace CrabDevPreloader
{
    [PatcherPluginInfo(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public sealed class CrabDevPreloader : BasePatcher
    {
        internal static CrabDevPreloader Instance { get; private set; }

        private AssemblyDefinition _unhollowerBaseLibAssembly;
        private TypeReference _il2CppObjectBaseRef;

        public override void Initialize()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            Instance = this;

            _unhollowerBaseLibAssembly = AssemblyDefinition.ReadAssembly(Path.Combine(Paths.BepInExRootPath, "core", "UnhollowerBaseLib.dll"));
            var il2CppObjectBaseType = _unhollowerBaseLibAssembly.MainModule.GetType("UnhollowerBaseLib.Il2CppObjectBase");
            _il2CppObjectBaseRef = _unhollowerBaseLibAssembly.MainModule.ImportReference(il2CppObjectBaseType);

            Log.LogInfo("Applying Harmony patches...");
            
            Harmony harmony = new(MyPluginInfo.PLUGIN_NAME);
            harmony.PatchAll(typeof(CrabDevPreloader));

            Log.LogInfo($"Initialized [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }


        [TargetType("UnityEngine.AssetBundleModule.dll", "UnityEngine.AssetBundle")]
        public void PatchAssetBundle(TypeDefinition assetBundleType)
        {
            Log.LogInfo("Patching AssetBundle...");

            // Only patch if the base type is not already Il2CppObjectBase
            if (assetBundleType.BaseType?.FullName == _il2CppObjectBaseRef.FullName)
            {
                Log.LogInfo("AssetBundle already inherits Il2CppObjectBase, skipping");
                return;
            }

            // Set the base type to Il2CppObjectBase
            assetBundleType.BaseType = assetBundleType.Module.ImportReference(_il2CppObjectBaseRef);
            Log.LogInfo("Set AssetBundle.BaseType = Il2CppObjectBase");

            // Skip if ctor already exists
            if (assetBundleType.Methods.Any(m =>
                m.IsConstructor &&
                m.Parameters.Count == 1 &&
                m.Parameters[0].ParameterType.FullName == "System.IntPtr"))
            {
                Log.LogInfo("AssetBundle(IntPtr) constructor already exists, skipping");
                return;
            }

            // Create AssetBundle(IntPtr ptr) constructor
            var ctor = new MethodDefinition(
                ".ctor",
                MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName,
                assetBundleType.Module.TypeSystem.Void
            );

            ctor.Parameters.Add(new ParameterDefinition("ptr", ParameterAttributes.None, assetBundleType.Module.TypeSystem.IntPtr));

            var il = ctor.Body.GetILProcessor();

            // base(ptr)
            var baseCtor = _il2CppObjectBaseRef.Resolve().Methods.First(m =>
                m.IsConstructor &&
                m.Parameters.Count == 1 &&
                m.Parameters[0].ParameterType.FullName == "System.IntPtr");

            il.Append(il.Create(MonoOpCodes.Ldarg_0));          // this
            il.Append(il.Create(MonoOpCodes.Ldarg_1));          // ptr argument
            il.Append(il.Create(MonoOpCodes.Call, assetBundleType.Module.ImportReference(baseCtor))); // call base ctor
            il.Append(il.Create(MonoOpCodes.Ret));              // return

            assetBundleType.Methods.Add(ctor);
            Log.LogInfo("Injected AssetBundle(IntPtr) constructor");
        }

        
        [HarmonyPatch(typeof(IL2CPPDetourMethodPatcher), "Init")]
        [HarmonyTranspiler]
        internal static IEnumerable<CodeInstruction> TranspileIL2CPPDetourMethodPatcherInit(IEnumerable<CodeInstruction> instructions)
        {
            List<CodeInstruction> codes = [.. instructions];

            bool injected = false;

            for (int i = 0; i < codes.Count; i++)
            {
                CodeInstruction code = codes[i];
                yield return code;

                // Look for: stloc.s (Exception ex)
                if (injected || code.opcode != SystemOpCodes.Stloc_S || code.operand is not LocalBuilder local || local.LocalIndex != 5 || local.LocalType != typeof(Exception))
                    continue;

                // Inject after storing ex
                yield return new CodeInstruction(SystemOpCodes.Ldloc_S, local); // load ex
                yield return new CodeInstruction(SystemOpCodes.Ldarg_0);        // load this
                yield return CodeInstruction.Call(typeof(DetourFailures), nameof(DetourFailures.Record));

                Instance.Log.LogInfo("Transpiled DetourFailures.Record after IL2CPPDetourMethodPatcher.Init's catch(Exception ex).");
                injected = true;
            }

            if (!injected)
                Instance.Log.LogWarning("Failed to transpile DetourFailures.Record after IL2CPPDetourMethodPatcher.Init's catch(Exception ex)!");
        }
    }
}