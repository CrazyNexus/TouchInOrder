using System;

using UIKit;
using MyGameController = de.crazynexus.GameController;

namespace de.crazynexus.iOS
{
	public partial class ViewController : UIViewController
	{


		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			MyGameController game = new MyGameController(new GameView(this));
			game.startGame();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
