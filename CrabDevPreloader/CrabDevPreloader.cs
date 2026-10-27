using BepInEx.Logging;
using BepInEx.Preloader.Core.Patching;
using CrabDevPreloader.Patchers;
using Mono.Cecil;
using System.Globalization;

namespace CrabDevPreloader
{
    [PatcherPluginInfo(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public sealed class CrabDevPreloader : BasePatcher
    {
        internal static CrabDevPreloader Instance { get; private set; }
        internal static ManualLogSource Logger { get; private set; }


        public override void Initialize()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            Instance = this;
            Logger = Log;

            DetourFailures.Init();
            Common.Init();

            Log.LogInfo($"Initialized [{MyPluginInfo.PLUGIN_NAME} {MyPluginInfo.PLUGIN_VERSION}]");
        }


        [TargetType("UnityEngine.AssetBundleModule.dll", "UnityEngine.AssetBundle")]
        public void PatchAssetBundle(TypeDefinition type)
            => AssetBundlePatcher.Patch(type);
    }
}