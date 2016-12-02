using System;
using System.Diagnostics;

namespace de.crazynexus
{
   public class GameController
   {
      IGameView gameView;

      public GameController(IGameView gameView)
      {
         Debug.WriteLine("GameController");

         this.gameView = gameView;
      }

      public void startGame()
      {
         Debug.WriteLine("startGame()");

         gameView.displayButtons();
      }
   }
}
