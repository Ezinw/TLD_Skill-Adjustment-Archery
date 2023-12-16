using HarmonyLib;
using Il2Cpp;

namespace SkillAdjustmentArchery
{
    namespace SkillAdjustmentRevolver
    {
        [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
        internal class ArcheryAdjustmentXP
        {
            public static void Postfix(SkillsManager __instance)
            {
                Skill archerySkill = __instance.GetSkill(SkillType.Archery);

                if (archerySkill != null)
                {
                    archerySkill.m_TierPoints[1] = Settings.settings.tier2;
                    archerySkill.m_TierPoints[2] = Settings.settings.tier3;
                    archerySkill.m_TierPoints[3] = Settings.settings.tier4;
                    archerySkill.m_TierPoints[4] = Settings.settings.tier5;
                }
            }
        }
        
        [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.Awake))]
        internal class SkillAdjustment
        {

            public static void Postfix(SkillsManager __instance)
            {
                __instance.m_Skill_Archery.m_LevelWhereCanFireFromCrouch = Settings.settings.CrouchLevel;

                __instance.m_Skill_Archery.m_SwayReduction[0] = Settings.settings.Sway0;
                __instance.m_Skill_Archery.m_DamageIncrease[0] = Settings.settings.Damage0;
                __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[0] = Settings.settings.Critical0;
                __instance.m_Skill_Archery.m_BleedOutTimeReduction[0] = Settings.settings.BleedOut0;
                __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[0] = Settings.settings.PerUseConditionLoss0;

                __instance.m_Skill_Archery.m_SwayReduction[1] = Settings.settings.Sway1;
                __instance.m_Skill_Archery.m_DamageIncrease[1] = Settings.settings.Damage1;
                __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[1] = Settings.settings.Critical1;
                __instance.m_Skill_Archery.m_BleedOutTimeReduction[1] = Settings.settings.BleedOut1;
                __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[1] = Settings.settings.PerUseConditionLoss1;

                __instance.m_Skill_Archery.m_SwayReduction[2] = Settings.settings.Sway2;
                __instance.m_Skill_Archery.m_DamageIncrease[2] = Settings.settings.Damage2;
                __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[2] = Settings.settings.Critical2;
                __instance.m_Skill_Archery.m_BleedOutTimeReduction[2] = Settings.settings.BleedOut2;
                __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[2] = Settings.settings.PerUseConditionLoss2;

                __instance.m_Skill_Archery.m_SwayReduction[3] = Settings.settings.Sway3;
                __instance.m_Skill_Archery.m_DamageIncrease[3] = Settings.settings.Damage3;
                __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[3] = Settings.settings.Critical3;
                __instance.m_Skill_Archery.m_BleedOutTimeReduction[3] = Settings.settings.BleedOut3;
                __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[3] = Settings.settings.PerUseConditionLoss3;

                __instance.m_Skill_Archery.m_SwayReduction[4] = Settings.settings.Sway4;
                __instance.m_Skill_Archery.m_DamageIncrease[4] = Settings.settings.Damage4;
                __instance.m_Skill_Archery.m_CriticalHitChanceIncrease[4] = Settings.settings.Critical4;
                __instance.m_Skill_Archery.m_BleedOutTimeReduction[4] = Settings.settings.BleedOut4;
                __instance.m_Skill_Archery.m_ConditionDegradeOnUseReduction[4] = Settings.settings.PerUseConditionLoss4;

            }

        }


        [HarmonyPatch(typeof(Skill_Archery), nameof(Skill_Archery.GetTierBenefits))]
        public class ArcheryBenefits
        {
            static void Postfix(ref string __result, Skill_Archery __instance)
            {
                SkillTiers currentTier = (SkillTiers)__instance.GetCurrentTierNumber();

                //crouch
                if (currentTier == SkillTiers.Beginner && Settings.settings.CrouchLevel == 1 ||
                    currentTier == SkillTiers.Novice && Settings.settings.CrouchLevel == 2 ||
                    currentTier == SkillTiers.Novice && Settings.settings.CrouchLevel == 1 ||
                    currentTier == SkillTiers.Skilled && Settings.settings.CrouchLevel == 3 ||
                    currentTier == SkillTiers.Skilled && Settings.settings.CrouchLevel == 2 ||
                    currentTier == SkillTiers.Skilled && Settings.settings.CrouchLevel == 1 ||
                    currentTier == SkillTiers.Expert && Settings.settings.CrouchLevel == 4 ||
                    currentTier == SkillTiers.Expert && Settings.settings.CrouchLevel == 3 ||
                    currentTier == SkillTiers.Expert && Settings.settings.CrouchLevel == 2 ||
                    currentTier == SkillTiers.Expert && Settings.settings.CrouchLevel == 1)
                { __result += "\nCan fire bow when crouched"; }

                //lvl 1
                if (currentTier == SkillTiers.Beginner && Settings.settings.Sway0 >= 1) { __result += $"\nBow sway reduced by {Settings.settings.Sway0}%"; }
                if (currentTier == SkillTiers.Beginner && Settings.settings.Damage0 >= 1) { __result += $"\nArrow damage increased by {Settings.settings.Damage0}%"; }
                if (currentTier == SkillTiers.Beginner && Settings.settings.Critical0 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.Critical0}%"; }
                if (currentTier == SkillTiers.Beginner && Settings.settings.BleedOut0 >= 1) { __result += $"\nBleed out time reduced by {Settings.settings.BleedOut0}%"; }
                if (currentTier == SkillTiers.Beginner && Settings.settings.PerUseConditionLoss0 >= 1) { __result += $"\nPer-use bow condition loss reduced by {Settings.settings.PerUseConditionLoss0}%"; }

                //lvl 2
                if (currentTier == SkillTiers.Novice && Settings.settings.Critical1 >= 1) { __result += $"\nCritical hit chance increased by {Settings.settings.Critical1}%"; }
                if (currentTier == SkillTiers.Novice && Settings.settings.BleedOut1 >= 1) { __result += $"\nBleed out time reduced by {Settings.settings.BleedOut1}%"; }
                if (currentTier == SkillTiers.Novice && Settings.settings.PerUseConditionLoss1 >= 1) { __result += $"\nPer-use bow condition loss reduced by {Settings.settings.PerUseConditionLoss1}%"; }
                if (currentTier == SkillTiers.Novice && Settings.settings.Sway1 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Sway: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Bow sway reduced by: {Settings.settings.Sway1}%";
                    }

                }
                if (currentTier == SkillTiers.Novice && Settings.settings.Damage1 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Arrow: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Arrow damage increased by: {Settings.settings.Damage1}%";
                    }

                }

                //lvl 3
                if (currentTier == SkillTiers.Skilled && Settings.settings.BleedOut2 >= 1) { __result += $"\nBleed out time reduced by {Settings.settings.BleedOut2}%"; }
                if (currentTier == SkillTiers.Skilled && Settings.settings.PerUseConditionLoss2 >= 1) { __result += $"\nPer-use bow condition loss reduced by {Settings.settings.PerUseConditionLoss2}%"; }
                if (currentTier == SkillTiers.Novice && Settings.settings.Sway2 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Sway: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Bow sway reduced by: {Settings.settings.Sway2}%";
                    }

                }
                if (currentTier == SkillTiers.Skilled && Settings.settings.Damage2 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Arrow: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Arrow damage increased by: {Settings.settings.Damage2}%";
                    }

                }
                if (currentTier == SkillTiers.Skilled && Settings.settings.Critical2 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Critical: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Critical hit chance increased by: {Settings.settings.Critical2}%";
                    }

                }

                //lvl 4
                if (currentTier == SkillTiers.Expert && Settings.settings.Sway3 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Sway: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Bow sway reduced by: {Settings.settings.Sway3}%";
                    }

                }
                if (currentTier == SkillTiers.Expert && Settings.settings.Damage3 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Arrow: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Arrow damage increased by: {Settings.settings.Damage3}%";
                    }

                }
                if (currentTier == SkillTiers.Expert && Settings.settings.Critical3 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Critical: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Critical hit chance increased by: {Settings.settings.Critical3}%";
                    }

                }
                if (currentTier == SkillTiers.Expert && Settings.settings.BleedOut3 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Bleed: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Bleed out time reduced by: {Settings.settings.BleedOut3}%";
                    }

                }
                if (currentTier == SkillTiers.Expert && Settings.settings.PerUseConditionLoss3 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Condition: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Per-use bow condition loss reduced by: {Settings.settings.PerUseConditionLoss3}%";
                    }

                }

                //lvl 5
                if (currentTier == SkillTiers.Master && Settings.settings.Sway4 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Sway: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Bow sway reduced by: {Settings.settings.Sway4}%";
                    }

                }
                if (currentTier == SkillTiers.Master && Settings.settings.Damage4 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Arrow: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Arrow damage increased by: {Settings.settings.Damage4}%";
                    }

                }
                if (currentTier == SkillTiers.Master && Settings.settings.Critical4 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Crit: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Critical hit chance increased by: {Settings.settings.Critical4}%";
                    }

                }
                if (currentTier == SkillTiers.Master && Settings.settings.BleedOut4 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Bleed: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Bleed out time reduced by: {Settings.settings.BleedOut4}%";
                    }

                }
                if (currentTier == SkillTiers.Master && Settings.settings.PerUseConditionLoss4 >= 1)
                {
                    int existingBenefitIndex = __result.IndexOf("Condition: ");
                    if (existingBenefitIndex != -1)
                    {
                        int endOfLineIndex = __result.IndexOf('\n', existingBenefitIndex);
                        if (endOfLineIndex != -1)
                        { __result = __result.Remove(existingBenefitIndex, endOfLineIndex - existingBenefitIndex); }
                        __result += $"Per-use bow condition loss reduced by: {Settings.settings.PerUseConditionLoss4}%";
                    }

                }

            }

        }

    }
}
