using System.Reflection;
using Harmony;
using HBS.Logging;

namespace LanceSpawnerDebugTool
{
    public static class Main
    {
        internal static ILog HBSLog;
        internal static ModSettings Settings;

        public static void Init(string modDir, string settings)
        {
            var harmony = HarmonyInstance.Create("io.github.mpstark.LanceSpawnerDebugTool");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            HBSLog = Logger.GetLogger("LanceSpawnerDebugTool");
            Settings = ModSettings.Parse(settings);
        }
    }
}
