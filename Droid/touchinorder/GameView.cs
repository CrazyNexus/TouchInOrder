using System;
using System.Collections.Generic;
using Android.App;
using Android.Widget;

namespace de.crazynexus.Droid
{
   public class GameView : IGameView
   {
      Activity activity;
      GridLayout gameLayout;

      public GameView(Activity activity)
      {
         this.activity = activity;

         // Get our layout resource,
         gameLayout = activity.FindViewById<GridLayout>(Resource.Id.gameLayout);
      }

      public IGameButton createGameButton()
      {
         return new GameButton(activity);
      }

      public void displayButtons(List<IGameButton> buttons)
      {
			double rows = Math.Sqrt(buttons.Count);
			if (rows != (int)rows)
			{
				throw new Exception("wring amount of rows");
			}
			gameLayout.ColumnCount = (int) rows;
			gameLayout.RowCount = (int)rows;

			var sizePoint = new Android.Graphics.Point();
			activity.WindowManager.DefaultDisplay.GetSize(sizePoint);
			int buttonWidth = (int)(sizePoint.X / rows);
			int buttonHeight = (int)(sizePoint.Y / rows);

         if (buttons[0] is GameButton)
         {
            foreach (GameButton button in buttons)
            {
               gameLayout.AddView(button.nativeButton);
					button.nativeButton.SetWidth(buttonWidth);
					button.nativeButton.SetHeight(buttonHeight);
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
