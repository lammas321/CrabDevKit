using BepInEx;
using BepInEx.IL2CPP;
//using CrabDevKit.Intermediary;
using CrabDevKit.Utilities;
using HarmonyLib;
using System.Globalization;

namespace CrabDevKit
{
    [BepInPlugin($"lammas123.{MyPluginInfo.PLUGIN_NAME}", MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
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

            //CrabNet.RegisterMessageHandler($"{MyPluginInfo.PLUGIN_NAME}:Test", (clientId, packet) => { Log.LogInfo($"Test message from {clientId}: {packet.ReadString()}"); });

            Harmony harmony = new(MyPluginInfo.PLUGIN_NAME);
            harmony.PatchAll(typeof(Patches));

            Log.LogInfo($"Initialized [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }
    }
}