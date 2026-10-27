using BepInEx.IL2CPP.Hook;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace CrabDevPreloader
{
    public static class DetourFailures
    {
        public static readonly List<string> failures = [];

        public static event Action FailureRecorded;

        internal static void Init()
        {
            CrabDevPreloader.Instance.Log.LogInfo("Applying Harmony patches for DetourFailures...");

            Harmony harmony = new(MyPluginInfo.PLUGIN_NAME);
            harmony.PatchAll(typeof(DetourFailures));
        }

        public static void Record(Exception ex, IL2CPPDetourMethodPatcher patcher)
        {
            string message = ex.Message;
            MethodBase original = patcher.Original;

            failures.Add($"Detour failed for {original}: {message}");

            FailureRecorded?.Invoke();
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
                if (injected || code.opcode != OpCodes.Stloc_S || code.operand is not LocalBuilder local || local.LocalIndex != 5 || local.LocalType != typeof(Exception))
                    continue;

                // Inject after storing ex
                yield return new CodeInstruction(OpCodes.Ldloc_S, local); // load ex
                yield return new CodeInstruction(OpCodes.Ldarg_0);        // load this
                yield return CodeInstruction.Call(typeof(DetourFailures), nameof(Record));

                CrabDevPreloader.Instance.Log.LogInfo("Transpiled DetourFailures.Record after IL2CPPDetourMethodPatcher.Init's catch(Exception ex).");
                injected = true;
            }

            if (!injected)
                CrabDevPreloader.Instance.Log.LogWarning("Failed to transpile DetourFailures.Record after IL2CPPDetourMethodPatcher.Init's catch(Exception ex)!");
        }
    }
}