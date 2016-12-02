using System;
using System.Collections.Generic;

namespace de.crazynexus
{
   public interface IGameView
   {
      void displayButtons(List<IGameButton> buttons);
      IGameButton createGameButton();
   }
}
