using System;
using UIKit;

namespace de.crazynexus.iOS
{
	class GameButton : IGameButton
	{
		public UIButton nativeButton { get; set; }

		public GameButton(Touched handler)
		{
			nativeButton = new UIButton();
			nativeButton.TouchUpInside += delegate
			{
				handler(this);
			};
		}

		public string Text
		{
			get
			{
				throw new NotImplementedException();
			}

			set
			{
				nativeButton.SetTitle(value, UIControlState.Normal);
			}
		}
	}
}