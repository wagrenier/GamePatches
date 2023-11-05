using Common;
using Game;
using HarmonyLib;

namespace SecondStoryFix;

[HarmonyPatch]
public class UltrawidePatch
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(UIManager), "CreateUILetterbox")]
    public static bool FixUIManagerLetterbox()
    {
        // Bypasses the method that creates the letterboxing
        return false;
    }
}