using System;
using System.Reflection;
using EFT.UI;
using HarmonyLib;
using SPT.Reflection.Patching;

namespace SPT.Custom.Patches;

/// <summary>
/// Does nothing and is never enabled. Kept so mods that disable it by type still load.
/// </summary>
[Obsolete("The server keeps GC on in raid, so this patch no longer does anything.")]
public class MemoryCollectionPatch : ModulePatch
{
    protected override MethodBase GetTargetMethod()
    {
        return AccessTools.Method(typeof(MenuTaskBar), nameof(MenuTaskBar.OnScreenChanged));
    }

    [PatchPostfix]
    public static void PatchPostfix() { }
}
