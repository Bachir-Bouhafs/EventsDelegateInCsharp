using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LesEvenementsEnCsharp
{
    class VideoCrypter
    {
      // Pour définir un événement il faut suivre trois étapes :

        // Etape 1 : Définir un delegate
        public delegate void VideoCryptedEventHandler(object source, EventArgs args);

        //Etape 2 : Définir un événement 
        public event VideoCryptedEventHandler VideoCrypted;

        //Etape 3 : déclencher l'événement 
        protected virtual void OnVideoCrypted()
        {
            if (VideoCrypted != null)
                VideoCrypted(this, EventArgs.Empty);
        }



        public void Formater(Video video)
        {
            Console.WriteLine("Video formaté...");
            Thread.Sleep(2000);
            OnVideoCrypted();
        }
    }
}
