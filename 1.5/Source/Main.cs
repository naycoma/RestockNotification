using HarmonyLib;
using Verse;

namespace RestockNotification;

[StaticConstructorOnStartup]
public static class Main {
    static Main() => new Harmony("bluebird.tammybee.restocknotification").PatchAll();
}
