using BepInEx;
using Valve.VR;

namespace ImpossibleLaVR
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public const string PLUGIN_GUID = "com.mlkamano.VRMods.ImpossibleLaVR";
        public const string PLUGIN_NAME = "ImpossibleLaVR";
        public const string PLUGIN_VERSION = "0.0.1";

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            InitSteamVR();
        }

        private static void InitSteamVR()
        {
            SteamVR.Initialize(true);
            SteamVR_Settings.instance.pauseGameWhenDashboardVisible = true;
        }
    }
}
