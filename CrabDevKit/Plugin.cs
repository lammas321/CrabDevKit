using BepInEx;
using BepInEx.IL2CPP;
using CrabDevKit.Utilities;
using HarmonyLib;
using System.Globalization;

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

            Log.LogInfo($"Initialized [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }
    }
}