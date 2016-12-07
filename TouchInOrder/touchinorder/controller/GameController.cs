using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace de.crazynexus
{
   public delegate void Touched(IGameButton button);

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
            IGameButton newButton = gameView.createGameButton(evaluateTouch);
            newButton.Text = "" + (i + 1);
            buttons.Add(newButton);
         }
      }

      void evaluateTouch(IGameButton sender)
      {
         Debug.WriteLine("Click-EventHandler, send is " + sender);

         if (buttons.Count == 0)
         {
            return;
         }


         if (sender == buttons[0])
         {
            Debug.WriteLine("Richtig geklickt");
            buttons.RemoveAt(0);
         }
         else
         {
            Debug.WriteLine("Falsch geklickt");
         }

         if (buttons.Count == 0)
         {
            Debug.WriteLine("Du hast gewonnen");
         }
      }

   }
}