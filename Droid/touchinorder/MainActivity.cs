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

         // Set our view from the "main" layout resource
         SetContentView(Resource.Layout.Main);

         GameView gameView = new GameView(this);
         //gameView.displayButtons();

         GameController controller = new GameController(gameView);
         controller.startGame();




      }
   }
}

