using System;
using System.Collections.Generic;
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

      public IGameButton createGameButton()
      {
         return new GameButton(activity);
      }

      public void displayButtons(List<IGameButton> buttons)
      {
         if (buttons[0] is GameButton)
         {
            foreach (GameButton button in buttons)
            {
               gameLayout.AddView(button.nativeButton);
               //button.nativeButton.Text = "Hallo";

            }
         }
         else
         {
            throw new NotImplementedException();
         }
         // and create a new button
         //button.Text = "Hallo Thomas-so geil";
         //gameLayout.AddView(button);

      }
   }
}
