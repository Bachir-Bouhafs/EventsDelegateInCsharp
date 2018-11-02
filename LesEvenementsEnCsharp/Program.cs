using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesEvenementsEnCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { titre = "film titanic" };

            //Editeur événement
            var videoCrypter = new VideoCrypter();

            //Abonné événement 
            var serviceMail = new ServiceMail();
            var serviceMessage = new ServiceMessage();

            videoCrypter.VideoCrypted += serviceMail.OnVideoCrypted;
            videoCrypter.VideoCrypted += serviceMessage.OnvideoCrypted;

            videoCrypter.Formater(video);

        }
    }
}
