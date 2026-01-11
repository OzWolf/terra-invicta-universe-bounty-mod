using HarmonyLib;
using PavonisInteractive.TerraInvicta;

namespace UniverseBounty.Patch
{
    // ReSharper disable InconsistentNaming
    [HarmonyPatch(typeof(TIHabState))]
    public static class TIHabStatePatch
    {
        [HarmonyPatch(nameof(TIHabState.GetModuleConstructionTimeModifier))]
        [HarmonyPostfix]
        public static void GetModuleConstructionTimeModifierPostfix(TIHabState __instance, ref float __result)
        {
            if (__instance.faction != GameControl.control.activePlayer) return;
            
            var newResult = __result;
            for (var i = 1; i <= Main.ModSettings.HabModuleBuildBoosts; i++)
                newResult *= 0.9f;
            
            __result = newResult;
        }
    }
}
