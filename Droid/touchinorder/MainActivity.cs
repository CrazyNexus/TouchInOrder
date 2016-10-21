using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace de.crazynexus.Droid
{
	[Activity(Label = "TouchInOrder", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			Console.WriteLine("OnCreate()");

			GameController controller = new GameController();
			controller.startGame();

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our layout resource,
			LinearLayout gameLayout = FindViewById<LinearLayout>(Resource.Id.gameLayout);

			// and create a new button
			var button = new Button(this);
			button.Text = "Hallo Thomas-so geil";
			gameLayout.AddView(button);

		}
	}
}

