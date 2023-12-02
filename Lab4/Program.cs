using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mediaPublisher = new Subject();

            var user1 = new Observer("User1");
            var user2 = new Observer("User2");

            mediaPublisher.Attach(user1);
            mediaPublisher.Attach(user2);


            mediaPublisher.PublishMedia("Photo1");
            mediaPublisher.PublishMedia("Video1");


            mediaPublisher.Detach(user1);


            mediaPublisher.PublishMedia("Photo2");
        }
    }
}
