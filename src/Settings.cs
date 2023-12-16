using ModSettings;
using System.Reflection;

namespace SkillAdjustmentArchery
{
    internal class Settings : JsonModSettings
    {

        [Section("Archery")]

        [Name("Archery Skills")]
        private readonly bool Archery = true;

        [Name("Fire Bow While Crouched")]
        [Description("Skill level required to fire bow while crouched. (Game default = 5) - Requires game reload to take effect")]
        [Slider(1, 5)]
        public int CrouchLevel = 5;

        [Name("Archery Level 1 ------------------------------")]
        [Description("Show or hide level 1 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Archery1 = false;

        [Name("          Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 0%)")]
        [Slider(0, 100)]
        public int Sway0 = 0;

        [Name("          Damage Increase")]
        [Description("Increase Damage. (Game default = 0%)")]
        [Slider(0, 200)]
        public int Damage0 = 0;

        [Name("          Critical Hit Chance")]
        [Description("Increase critical hit chance. (Game default = 0%)")]
        [Slider(0, 100)]
        public int Critical0 = 0;

        [Name("          Bleed Out Time Reduction")]
        [Description("Increase the time for animals to bleed out. (Game default = 0%)")]
        [Slider(0, 200)]
        public int BleedOut0 = 0;

        [Name("          Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 0%)")]
        [Slider(0, 100)]
        public int PerUseConditionLoss0 = 0;

        [Name("Archery Level 2 ------------------------------")]
        [Description("Show or hide level 2 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Archery2 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 15)")]
        [Slider(15, 500)]
        public int tier2 = 15;

        [Name("          Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 25%)")]
        [Slider(0, 100)]
        public int Sway1 = 25;

        [Name("          Damage Increase")]
        [Description("Increase Damage. (Game default = 10%)")]
        [Slider(0, 200)]
        public int Damage1 = 10;

        [Name("          Critical Hit Chance")]
        [Description("Increase critical hit chance. (Game default = 0%)")]
        [Slider(0, 100)]
        public int Critical1 = 0;

        [Name("          Bleed Out Time Reduction")]
        [Description("Increase the time for animals to bleed out. (Game default = 0%)")]
        [Slider(0, 200)]
        public int BleedOut1 = 0;

        [Name("          Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 0%)")]
        [Slider(0, 100)]
        public int PerUseConditionLoss1 = 0;

        [Name("Archery Level 3 ------------------------------")]
        [Description("Show or hide level 3 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Archery3 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 40)")]
        [Slider(40, 500)]
        public int tier3 = 40;

        [Name("          Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 50%)")]
        [Slider(0, 100)]
        public int Sway2 = 50;

        [Name("          Damage Increase")]
        [Description("Increase Damage. (Game default = 10%)")]
        [Slider(0, 200)]
        public int Damage2 = 10;

        [Name("          Critical Hit Chance")]
        [Description("Increase critical hit chance. (Game default = 15%)")]
        [Slider(0, 100)]
        public int Critical2 = 15;

        [Name("          Bleed Out Time Reduction")]
        [Description("Increase the time for animals to bleed out. (Game default = 0%)")]
        [Slider(0, 200)]
         public int BleedOut2 = 0;

        [Name("          Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 0%)")]
        [Slider(0, 100)]
        public int PerUseConditionLoss2 = 0;

        [Name("Archery Level 4 ------------------------------")]
        [Description("Show or hide level 4 skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Archery4 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 75)")]
        [Slider(75, 500)]
        public int tier4 = 75;

        [Name("          Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 75%)")]
        [Slider(0, 100)]
        public int Sway3 = 75;

        [Name("          Damage Increase")]
        [Description("Increase Damage. (Game Default = 10%)")]
        [Slider(0, 200)]
        public int Damage3 = 10;

        [Name("          Critical Hit Chance")]
        [Description("Increase critical hit chance. (Game default = 25%)")]
        [Slider(0, 100)]
        public int Critical3 = 25;

        [Name("          Bleed Out Time Reduction")]
        [Description("Increase the time for animals to bleed out. (Game default = 25%)")]
        [Slider(0, 200)]
        public int BleedOut3 = 25;

        [Name("          Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 50%)")]
        [Slider(0, 100)]
        public int PerUseConditionLoss3 = 50;

        [Name("Archery Level 5 ------------------------------")]
        [Description("Show or hide level  skills - All changes made in game require a game reload to take effect")]
        [Choice("+", "-")]
        public bool Archery5 = false;

        [Name("         - XP for level up")]
        [Description("Set the number of skill points needed for next tier.(Game default = 125)")]
        [Slider(125, 625)]
        public int tier5 = 125;

        [Name("          Bow Sway Reduction")]
        [Description("Reduce bow sway. (Game default = 75%)")]
        [Slider(0, 100)]
        public int Sway4 = 75;

        [Name("          Damage Increase")]
        [Description("Increase Damage. (Game default = 25%)")]
        [Slider(0, 200)]
        public int Damage4 = 25;

        [Name("          Critical Hit Chance")]
        [Description("=Increase critical hit chance. (Game default = 50%)")]
        [Slider(0, 100)]
        public int Critical4 = 50;

        [Name("          Bleed Out Time Reduction")]
        [Description("Increase the time for animals to bleed out. (Game default = 50%)")]
        [Slider(0, 200)]
        public int BleedOut4 = 50;

        [Name("          Condition loss")]
        [Description("Reduce the amount of condition loss each use. (Game default = 50%)")]
        [Slider(0, 100)]
        public int PerUseConditionLoss4 = 50;


        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(Archery)   ||
                field.Name == nameof(Archery1)  ||
                field.Name == nameof(Archery2)  ||
                field.Name == nameof(Archery3)  ||
                field.Name == nameof(Archery4)  ||
                field.Name == nameof(Archery5))
            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            SetFieldVisible(nameof(CrouchLevel), Archery);

            SetFieldVisible(nameof(Archery1), Archery);
            SetFieldVisible(nameof(Sway0), (Archery1) && Archery);
            SetFieldVisible(nameof(Damage0), (Archery1) && Archery);
            SetFieldVisible(nameof(Critical0), (Archery1) && Archery);
            SetFieldVisible(nameof(BleedOut0), (Archery1) && Archery);
            SetFieldVisible(nameof(PerUseConditionLoss0), (Archery1) && Archery);

            SetFieldVisible(nameof(Archery2), Archery);
            SetFieldVisible(nameof(Sway1), (Archery2) && Archery);
            SetFieldVisible(nameof(Damage1), (Archery2) && Archery);
            SetFieldVisible(nameof(Critical1), (Archery2) && Archery);
            SetFieldVisible(nameof(BleedOut1), (Archery2) && Archery);
            SetFieldVisible(nameof(PerUseConditionLoss1), (Archery2) && Archery);
            SetFieldVisible(nameof(tier2), (Archery2) && Archery);

            SetFieldVisible(nameof(Archery3), Archery);
            SetFieldVisible(nameof(Sway2), (Archery3) && Archery);
            SetFieldVisible(nameof(Damage2), (Archery3) && Archery);
            SetFieldVisible(nameof(Critical2), (Archery3) && Archery);
            SetFieldVisible(nameof(BleedOut2), (Archery3) && Archery);
            SetFieldVisible(nameof(PerUseConditionLoss2), (Archery3) && Archery);
            SetFieldVisible(nameof(tier3), (Archery3) && Archery);

            SetFieldVisible(nameof(Archery4), Archery);
            SetFieldVisible(nameof(Sway3), (Archery4) && Archery);
            SetFieldVisible(nameof(Damage3), (Archery4) && Archery);
            SetFieldVisible(nameof(Critical3), (Archery4) && Archery);
            SetFieldVisible(nameof(BleedOut3), (Archery4) && Archery);
            SetFieldVisible(nameof(PerUseConditionLoss3), (Archery4) && Archery);
            SetFieldVisible(nameof(tier4), (Archery4) && Archery);

            SetFieldVisible(nameof(Archery5), Archery);
            SetFieldVisible(nameof(Sway4), (Archery5) && Archery);
            SetFieldVisible(nameof(Damage4), (Archery5) && Archery);
            SetFieldVisible(nameof(Critical4), (Archery5) && Archery);
            SetFieldVisible(nameof(BleedOut4), (Archery5) && Archery);
            SetFieldVisible(nameof(PerUseConditionLoss4), (Archery5) && Archery);
            SetFieldVisible(nameof(tier5), (Archery5) && Archery);

        }


        internal static Settings settings;
        internal static void OnLoad()
        {
            settings = new Settings();
            settings.AddToModSettings("Skill-Adjustment-Archery");
            settings.RefreshFields();
        }
    }
}
