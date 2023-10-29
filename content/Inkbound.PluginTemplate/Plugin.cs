using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;

namespace Inkbound.PluginTemplate {
	[BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
	public class Plugin : BaseUnityPlugin {
		public const string PLUGIN_GUID = "Inkbound.PluginTemplate";
		public const string PLUGIN_NAME = "Template Plugin";
		public const string PLUGIN_VERSION = "1.0.0";
        	public static readonly Harmony HarmonyInstance = new Harmony(PLUGIN_GUID);
        	internal static ManualLogSource log;
		private void Awake() {
			// Plugin startup logic
			log = Logger;
			HarmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
			Logger.LogInfo($"Plugin {PLUGIN_GUID} is loaded!");
    		}
	}
}