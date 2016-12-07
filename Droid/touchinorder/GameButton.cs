using System;
using Android.Content;
using Android.Widget;

namespace de.crazynexus.Droid
{
   public class GameButton : IGameButton
   {
      public Button nativeButton { get; set; }

      public string Text
      {
         get
         {
            return nativeButton.Text;
         }

         set
         {
            nativeButton.Text = value;
         }
      }

      public GameButton(Context context, Touched handler)
      {
         nativeButton = new Button(context);
         nativeButton.Click += delegate
         {
            handler(this);
         };
      }
   }
}
