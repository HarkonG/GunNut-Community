using RimWorld;
using System.Collections.Generic;
using Verse;

namespace GunNutCommunity
{
	[StaticConstructorOnStartup]
	public static class GNCPDefDisabler
	{
		static GNCPDefDisabler() => GNCPDefDisabler.DefDisablerList();

		public static void DefDisablerList()
		{
			bool value1 = !GNCPMod.settings.enable_GNCP_KS23;
			if (value1)
			{
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_KSTwentyThree"));
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_KSTwentyThree"));
			}

			bool value2 = !GNCPMod.settings.enable_GNCP_P90;
			if (value2)
			{
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_PNinety"));
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_PNinety"));
			}			

			bool value3 = !GNCPMod.settings.enable_GNCP_SR25;
			if (value3)
			{
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_SRTwentyFive"));
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_SRTwentyFive"));
			}

			bool value4 = !GNCPMod.settings.enable_GNCP_GalilACE;
			if (value4)
			{
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_GalilACE"));
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_GalilACE"));
			}

			//bool value5 = !GNCPMod.settings.enable_GNCP_AT4;
			//if (value5)
			//{
			//	GNCPDefDisabler.DisableDef(ThingDef.Named("GN_ATFour"));
			//	GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_ATFour"));
			//}

			bool value6 = !GNCPMod.settings.enable_GNCP_StG44;
			if (value6)
			{
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_StGFortyFour"));
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_StGFortyFour"));
			}		

			bool value8 = !GNCPMod.settings.enable_GNCP_MG3;
			if (value8)
			{
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_MGThree"));
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_MGThree"));
			}

			bool value9 = !GNCPMod.settings.enable_GNCP_G98;
			if (value9)
			{
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_GlockFLUX"));
				GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_GlockFLUX"));
			}

            bool value10 = !GNCPMod.settings.enable_GNCP_M16A4;
            if (value10)
            {
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_M16AFour"));
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_M16AFour"));
            }

            bool value11 = !GNCPMod.settings.enable_GNCP_M2HB;
            if (value11)
            {
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_M2HB"));
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_M2HB"));
            }

            bool value12 = !GNCPMod.settings.enable_GNCP_GreyHawk;
            if (value12)
            {
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_GreyHawk"));
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_GreyHawk"));
            }

            bool value13 = !GNCPMod.settings.enable_GNCP_AA12;
            if (value13)
            {
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_AATwelve"));
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_AATwelve"));
            }

            bool value14 = !GNCPMod.settings.enable_GNCP_M202;
            if (value14)
            {
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_M202F"));
                GNCPDefDisabler.DisableDef(ThingDef.Named("GN_Bullet_M202F"));
            }
        }

		public static void DisableDef(ThingDef def)
		{
			List<ResearchProjectDef> researchPrerequisites = def.researchPrerequisites;

			if (researchPrerequisites != null)
			{
				researchPrerequisites.Clear();
			}

			List<string> weaponTags = def.weaponTags;

			if (weaponTags != null)
			{
				weaponTags.Clear();
			}

			def.deepCommonality = 0f;

			def.generateCommonality = 0f;

			def.tradeability = Tradeability.None;

			List<ThingCategoryDef> thingCategories = def.thingCategories;

			if (thingCategories != null)
			{
				thingCategories.Clear();
			}

			List<ThingCategoryDef> thingCategories2 = def.thingCategories;

			if (thingCategories2 != null)
			{
				thingCategories2.Add(ThingCategoryDefOf.Chunks);
			}

			foreach (RecipeDef recipeDef in DefDatabase<RecipeDef>.AllDefsListForReading)
			{
				bool value1 = recipeDef.ProducedThingDef == def;
				if (value1)
				{
					List<ThingDef> recipeUsers = recipeDef.recipeUsers;
					if (recipeUsers != null)
					{
						recipeUsers.Clear();
					}
					List<ResearchProjectDef> researchPrerequisites2 = recipeDef.researchPrerequisites;
					if (researchPrerequisites2 != null)
					{
						researchPrerequisites2.Clear();
					}
					recipeDef.researchPrerequisite = null;
				}
			}

			bool value2 = DefDatabase<ThingDef>.AllDefsListForReading.Contains(def);

			if (value2)
			{
				DefDatabase<ThingDef>.AllDefsListForReading.Remove(def);
			}
		}
	}
}