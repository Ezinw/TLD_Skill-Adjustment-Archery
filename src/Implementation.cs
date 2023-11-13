using MelonLoader;

namespace SkillAdjustmentArchery
{ 
	internal sealed class Implementation : MelonMod
	{
		public override void OnInitializeMelon()
		{
            Settings.OnLoad();
        }
	
	}

}
