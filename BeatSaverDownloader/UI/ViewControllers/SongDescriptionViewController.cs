﻿using BeatSaberMarkupLanguage.Attributes;
using HMUI;
namespace BeatSaverDownloader.UI.ViewControllers
{
    public class SongDescriptionViewController : BeatSaberMarkupLanguage.ViewControllers.BSMLResourceViewController
    {
        public override string ResourceName => "BeatSaverDownloader.UI.BSML.songDescription.bsml";

        [UIComponent("songDescription")]
        internal TextPageScrollView songDescription;

        protected override void DidDeactivate(bool removedFromHierarchy, bool screenSystemDisabling)
        {
            base.DidDeactivate(removedFromHierarchy, screenSystemDisabling);
        }

        internal void ClearData()
        {
            if (songDescription)
                songDescription.SetText("");
        }

        internal void Initialize(string description)
        {
            songDescription.SetText(description);
        }

        [UIAction("#post-parse")]
        internal void Setup()
        {
        }
    }
}