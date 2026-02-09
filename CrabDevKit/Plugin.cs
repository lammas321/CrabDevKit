using BepInEx;
using BepInEx.IL2CPP;
using CrabDevKit.Utilities;
using HarmonyLib;
using System.Globalization;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CrabDevKit
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public sealed class CrabDevKit : BasePlugin
    {
        internal static CrabDevKit Instance { get; private set; }

        internal static CrabNet CrabNet { get; private set; }

        public override void Load()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            Instance = this;

            CrabNet = new();
            FakeClients.Init();

            Harmony harmony = new(MyPluginInfo.PLUGIN_NAME);
            harmony.PatchAll(typeof(Patches));

            SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)DetourFailuresCheck;

            Log.LogInfo($"Initialized [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }


        private void DetourFailuresCheck(Scene _, LoadSceneMode __)
        {
            SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)DetourFailuresCheck;

            CrabDevPreloader.DetourFailures.FailureRecorded += PromptDetourFailures;

            if (CrabDevPreloader.DetourFailures.failures.Count == 0)
                return;

            PromptDetourFailures();
        }

        private void PromptDetourFailures()
        {
            foreach (string failure in CrabDevPreloader.DetourFailures.failures)
                Prompt.Instance.NewPrompt("CrabDevKit - DetourFailures", $"<size=26>{failure}</size>");
            CrabDevPreloader.DetourFailures.failures.Clear();

            Prompt.Instance.NewPrompt("CrabDevKit - DetourFailures", "<size=26>The most common way to fix these issue(s) is to restart your computer.\nHowever, if that doesn't help, then reach out on CrabGame+ for additional support!\n\nDiscord: <link=\"https://discord.gg/jBGMZqndT3\"><u>https://discord.gg/jBGMZqndT3</u></link></size>");
            Prompt.Instance.prompts[^1].GetComponent<PromptPrefab>().filler.gameObject.AddComponent<LinkOpener>();

            Prompt.Instance.NewPrompt("CrabDevKit - DetourFailures", $"<size=26>Detour failed for {CrabDevPreloader.DetourFailures.failures.Count} Il2Cpp method(s).\n\nYou may find the failed patches in your console or LogOutput.txt, but they'll also be shown here!\n\nPress Continue for more.</size>");
        }
    }
}