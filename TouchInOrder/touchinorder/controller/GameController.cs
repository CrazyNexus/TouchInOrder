using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace de.crazynexus
{
	public class GameController
	{
		IGameView gameView;
		List<IGameButton> buttons;

		public GameController(IGameView gameView)
		{
			Debug.WriteLine("GameController");

			this.gameView = gameView;
			generateButtons();
		}

		public void startGame()
		{
			Debug.WriteLine("startGame()");

			gameView.displayButtons(Util.randomizedList(buttons));
		}

		void generateButtons()
		{
			buttons = new List<IGameButton>();
			for (int i = 0; i < 9; i++)
			{
				IGameButton newButton = gameView.createGameButton();
				newButton.Text = "" + (i + 1);
				buttons.Add(newButton);
			}
		}

	}
}