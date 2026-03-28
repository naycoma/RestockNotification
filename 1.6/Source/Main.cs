using System.Linq;
using System.Reflection;
using HarmonyLib;
using Verse;

namespace RestockNotification;

[StaticConstructorOnStartup]
public static class Main {
    static Main() {
        // Injected from About/About.xml at build time via AssemblyMetadata in mod.csproj
        string packageId = Assembly.GetExecutingAssembly()
            .GetCustomAttributes<AssemblyMetadataAttribute>()
            .First(a => a.Key == "PackageId").Value;
        new Harmony(packageId).PatchAll();
    }
}
