using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenementsEnCsharp
{
   public class ServiceMessage
    {
        public void OnvideoCrypted(object source, EventArgs eventArgs)
        {
            Console.WriteLine("Le service a envoyé un message...");
            Console.ReadLine();
        }
    }
}
