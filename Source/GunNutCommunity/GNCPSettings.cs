using UnityEngine;
using Verse;

namespace GunNutCommunity
{
	internal class GNCPSettings : ModSettings
	{
		/// <summary>
		/// The settings our mod has.
		/// </summary>
		public bool enable_GNCP_KS23 = true;
		public bool enable_GNCP_P90 = true;
		public bool enable_GNCP_SR25 = true;
		public bool enable_GNCP_GalilACE = true;
		//public bool enable_GNCP_AT4 = true;
		public bool enable_GNCP_StG44 = true;
		public bool enable_GNCP_MG3 = true;
		public bool enable_GNCP_G98 = true;
		//public bool enable_GNCP_M16A4 = true;
		//public bool enable_GNCP_M2HB = true;
		//public bool enable_GNCP_GreyHawk = true;
		//public bool enable_GNCP_AA12 = true;
		//public bool enable_GNCP_M202 = true;

		public bool enable_GNCP_nicknames = true;

		public void ResetSavedDefs()
		{
			this.enable_GNCP_KS23 = true;
			this.enable_GNCP_P90 = true;
			this.enable_GNCP_SR25 = true;
			this.enable_GNCP_GalilACE = true;
			//this.enable_GNCP_AT4 = true;
			this.enable_GNCP_StG44 = true;
			this.enable_GNCP_MG3 = true;		
			this.enable_GNCP_G98 = true;
			//this.enable_GNCP_M16A4 = true;
			//this.enable_GNCP_M2HB = true;
			//this.enable_GNCP_GreyHawk = true;
			//this.enable_GNCP_AA12 = true;
			//this.enable_GNCP_M202 = true;

			this.enable_GNCP_nicknames = true;
		}

		/// <summary>
		/// The part that writes our settings to file. Note that saving is by ref.
		/// </summary>
		public override void ExposeData()
		{
			base.ExposeData();
			Scribe_Values.Look<bool>(ref this.enable_GNCP_KS23, "enable_GNCP_KS23", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GNCP_P90, "enable_GNCP_P90", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GNCP_SR25, "enable_GNCP_SR25", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GNCP_GalilACE, "enable_GNCP_GalilACE", true, false);
			//Scribe_Values.Look<bool>(ref this.enable_GNCP_AT4, "enable_GNCP_AT4", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GNCP_StG44, "enable_GNCP_StG44", true, false);
			Scribe_Values.Look<bool>(ref this.enable_GNCP_MG3, "enable_GNCP_MG3", true, false);			
			Scribe_Values.Look<bool>(ref this.enable_GNCP_G98, "enable_GNCP_G98", true, false);
			//Scribe_Values.Look<bool>(ref this.enable_GNCP_M16A4, "enable_GNCP_M16A4", true, false);			
			//Scribe_Values.Look<bool>(ref this.enable_GNCP_M2HB, "enable_GNCP_M2HB", true, false);
			//Scribe_Values.Look<bool>(ref this.enable_GNCP_GreyHawk, "enable_GNCP_GreyHawk", true, false);
			//Scribe_Values.Look<bool>(ref this.enable_GNCP_AA12, "enable_GNCP_AA12", true, false);
			//Scribe_Values.Look<bool>(ref this.enable_GNCP_M202, "enable_GNCP_M202", true, false);

			Scribe_Values.Look<bool>(ref this.enable_GNCP_nicknames, "enable_GNCP_nicknames", true, false);
		}

		public void DoSettingsWindowContents(Rect settingsCanvas)
		{
			Listing_Standard list = new Listing_Standard
			{
				ColumnWidth = (settingsCanvas.width - 17) / 2
			};

			list.Begin(settingsCanvas);

			Text.Font = GameFont.Medium;
			list.Label("settings_GNCP_EnableHeader".Translate());
			list.GapLine();

			Text.Font = GameFont.Small;
			list.Label("settings_GNCP_EnableDescription".Translate());
			list.Gap();

			list.CheckboxLabeled("enable_GNCP_KS23".Translate(), ref this.enable_GNCP_KS23, null);
			list.CheckboxLabeled("enable_GNCP_P90".Translate(), ref this.enable_GNCP_P90, null);
			list.CheckboxLabeled("enable_GNCP_SR25".Translate(), ref this.enable_GNCP_SR25, null);
			list.CheckboxLabeled("enable_GNCP_GalilACE".Translate(), ref this.enable_GNCP_GalilACE, null);
			list.Label("Because of how is implemented the AT4 cannot be disabled right now");
			//list.CheckboxLabeled("enable_GNCP_AT4".Translate(), ref this.enable_GNCP_AT4, null);
			list.CheckboxLabeled("enable_GNCP_StG44".Translate(), ref this.enable_GNCP_StG44, null);
			list.CheckboxLabeled("enable_GNCP_MG3".Translate(), ref this.enable_GNCP_MG3, null);			
			list.CheckboxLabeled("enable_GNCP_G98".Translate(), ref this.enable_GNCP_G98, null);
			//list.CheckboxLabeled("enable_GNCP_M16A4".Translate(), ref this.enable_GNCP_M16A4, null);			
			//list.CheckboxLabeled("enable_GNCP_M2HB".Translate(), ref this.enable_GNCP_M2HB, null);
			//list.CheckboxLabeled("enable_GNCP_GreyHawk".Translate(), ref this.enable_GNCP_GreyHawk, null);
			//list.CheckboxLabeled("enable_GNCP_AA12".Translate(), ref this.enable_GNCP_AA12, null);
			//list.CheckboxLabeled("enable_GNCP_M202".Translate(), ref this.enable_GNCP_M202, null);
			list.Gap();
			list.Gap();
			list.Gap();
			list.Gap();
			list.Gap();

			list.Label("settings_GNCP_EndDescription".Translate());

			list.NewColumn();

			Text.Font = GameFont.Medium;
			list.Label("settings_GNCP_EnableNickNameHeader".Translate());
			list.GapLine();

			Text.Font = GameFont.Small;
			list.Label("settings_GNCP_EnableNickNameDescription".Translate());
			list.Gap();

			list.CheckboxLabeled("enable_GNCP_nicknames".Translate(), ref this.enable_GNCP_nicknames, null);

			list.End();
		}
	}
}