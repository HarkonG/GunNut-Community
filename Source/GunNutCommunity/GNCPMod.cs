using UnityEngine;
using Verse;

namespace GunNutCommunity
{
	internal class GNCPMod : Mod
	{
		/// <summary>
		/// A reference to our settings.
		/// </summary>
		public static GNCPSettings settings;

		/// <summary>
		/// A mandatory constructor which resolves the reference to our settings.
		/// </summary>
		/// /// <param name="content"></param>
		public GNCPMod(ModContentPack content) : base(content)
		{
			GNCPMod.settings = base.GetSettings<GNCPSettings>();
		}

		/// <summary>
		/// The (optional) GUI part to set your settings.
		/// </summary>
		/// <param name="settingsCanvas">A Unity Rect with the size of the settings window.</param>
		public override void DoSettingsWindowContents(Rect settingsCanvas)
		{
			base.DoSettingsWindowContents(settingsCanvas);
			GNCPMod.settings.DoSettingsWindowContents(settingsCanvas);
		}

		/// <summary>
		/// Override SettingsCategory to show up in the list of settings.
		/// Using .Translate() is optional, but does allow for localisation.
		/// </summary>
		/// <returns>The (translated) mod name.</returns>
		public override string SettingsCategory()
		{
			return "GUN NUT-Community Pack";
		}

		public override void WriteSettings()
		{
			base.WriteSettings();
			GNCPDefDisabler.DefDisablerList();
			GNCPNickNames.EnableNickNames();
		}
	}
}