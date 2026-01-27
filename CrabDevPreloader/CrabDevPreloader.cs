using BepInEx;
using BepInEx.Preloader.Core.Patching;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System.IO;
using System.Linq;

namespace CrabDevPreloader
{
    [PatcherPluginInfo(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public sealed class CrabDevPreloader : BasePatcher
    {
        private AssemblyDefinition _unhollowerBaseLibAssembly;
        private TypeReference _il2CppObjectBaseRef;

        public override void Initialize()
        {
            _unhollowerBaseLibAssembly = AssemblyDefinition.ReadAssembly(Path.Combine(Paths.BepInExRootPath, "core", "UnhollowerBaseLib.dll"));
            var il2CppObjectBaseType = _unhollowerBaseLibAssembly.MainModule.GetType("UnhollowerBaseLib.Il2CppObjectBase");
            _il2CppObjectBaseRef = _unhollowerBaseLibAssembly.MainModule.ImportReference(il2CppObjectBaseType);

            Log.LogInfo("Initialized");
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

            il.Append(il.Create(OpCodes.Ldarg_0));          // this
            il.Append(il.Create(OpCodes.Ldarg_1));          // ptr argument
            il.Append(il.Create(OpCodes.Call, assetBundleType.Module.ImportReference(baseCtor))); // call base ctor
            il.Append(il.Create(OpCodes.Ret));              // return

            assetBundleType.Methods.Add(ctor);
            Log.LogInfo("Injected AssetBundle(IntPtr) constructor");
        }
    }
}