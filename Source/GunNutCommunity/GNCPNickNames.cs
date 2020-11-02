using Verse;

namespace GunNutCommunity
{
	[StaticConstructorOnStartup]
	public static class GNCPNickNames
	{
		static GNCPNickNames() => GNCPNickNames.EnableNickNames();

		public static void ChangeLabel(ThingDef def, string newLabel) => def.label = newLabel.Translate();

		public static void EnableNickNames()
		{
			bool value1 = GNCPMod.settings.enable_GNCP_nicknames;
			if (value1)
			{
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_KSTwentyThree"), "Label_GNCP_KS23_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_PNinety"), "Label_GNCP_P90_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_SRTwentyFive"), "Label_GNCP_SR25_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_GalilACE"), "Label_GNCP_GalilACE_NN");
				//GNCPNickNames.ChangeLabel(ThingDef.Named("GN_ATFour"), "Label_GNCP_AT4_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_StGFortyFour"), "Label_GNCP_StG44_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_MGThree"), "Label_GNCP_MG3_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_GlockFLUX"), "Label_GNCP_G98_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_M16AFour"), "Label_GNCP_M16A4_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_M2HB"), "Label_GNCP_M2HB_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_GreyHawk"), "Label_GNCP_GreyHawk_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_AATwelve"), "Label_GNCP_AA12_NN");
				GNCPNickNames.ChangeLabel(ThingDef.Named("GN_M202F"), "Label_GNCP_M202_NN");
			}
		}
	}
}