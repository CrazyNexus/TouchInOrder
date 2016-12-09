using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace de.crazynexus.iOS
{
	public class GameView : IGameView
	{
		UIViewController controller;
		public GameView(UIViewController controller)
		{
			this.controller = controller;
		}

		public IGameButton createGameButton(Touched handler)
		{
			return new GameButton(handler);
		}

		public void displayButtons(List<IGameButton> buttons)
		{
			var screenHeight = controller.View.Bounds.Height;
			var screenWidth = controller.View.Bounds.Width;
			var rows = Math.Sqrt(buttons.Count);
			if (rows != (int)rows)
			{
				throw new Exception("wrong button count");
			}

			var buttonHeight = screenHeight / rows;
			var buttonWith = screenWidth / rows;

			var currentRow = 0;
			var currentColumn = 0;

			foreach (GameButton button in buttons)
			{
				//for (int column = 1; column <= rows ; column++)
				//{
				//	for (int row = 1; row <= rows; row++)
				//	{
				controller.View.Add(button.nativeButton);
				button.nativeButton.BackgroundColor = UIColor.Blue;
				button.nativeButton.Frame = new CGRect(currentColumn * buttonWith, currentRow * buttonHeight, buttonWith, buttonHeight);
				button.nativeButton.Layer.CornerRadius = 10;
				currentColumn++;

				if (currentColumn == (int)rows)
				{
					currentRow++;
					currentColumn = 0;
				}

				//	}
				//}
			}
		}
	}
}
