using HarmonyLib;
using RimWorld;
using RimWorld.Planet;
using Verse;

namespace RestockNotification;

[HarmonyPatch]
public static class Patch  {
    [HarmonyPatch(typeof(Settlement_TraderTracker))]
    [HarmonyPatch(nameof(Settlement_TraderTracker.TryDestroyStock)), HarmonyPrefix]
    static void TryDestroyStock_Prefix(Settlement_TraderTracker __instance) {
        int lastStockGenerationTicks = __instance.lastStockGenerationTicks;
        int regenerateStockEveryDays = __instance.RegenerateStockEveryDays;

        bool isRestockDue = Find.TickManager.TicksGame - lastStockGenerationTicks > regenerateStockEveryDays * GenDate.TicksPerDay;
        if (!isRestockDue) return;

        ThingOwner<Thing> stock = __instance.stock;
        if (stock == null) return;

        string label = "RestockNotification.RestockLetterLabel".Translate();
        string text = "RestockNotification.RestockLetterDesc".Translate(__instance.settlement.Named("SETTLEMENT"));
        Find.LetterStack.ReceiveLetter(label, text, LetterDefOf.NeutralEvent, __instance.settlement);
    }
}
