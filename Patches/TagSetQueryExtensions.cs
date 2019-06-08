using System.Collections.Generic;
using BattleTech.Data;
using Harmony;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global

namespace LanceSpawnerDebugTool.Patches
{
    [HarmonyPatch(typeof(TagSetQueryExtensions), "GetMatchingUnitDefs")]
    public static class GetMatchingUnitDefsPatch
    {
        public static void Postfix(List<UnitDef_MDD> __result)
        {
            Main.HBSLog.Log("GetMatchingUnitDefs returns:");
            foreach (var unitDefMdd in __result)
            {
                Main.HBSLog.Log($"  {unitDefMdd.UnitDefID}");
            }
        }
    }
}
