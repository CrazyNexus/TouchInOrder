using System;
using Android.App;
using Android.Widget;

namespace de.crazynexus.Droid
{
   public class GameView : IGameView
   {
      Activity activity;
      LinearLayout gameLayout;

      public GameView(Activity activity)
      {
         this.activity = activity;

         // Get our layout resource,
         gameLayout = activity.FindViewById<LinearLayout>(Resource.Id.gameLayout);
      }

      public void displayButtons()
      {
         // and create a new button
         var button = new Button(activity);
         button.Text = "Hallo Thomas-so geil";
         gameLayout.AddView(button);

      }
   }
}
