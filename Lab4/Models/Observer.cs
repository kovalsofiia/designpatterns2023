using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Observer : IObserver
    {
        private string _username;

        public Observer(string username)
        {
            _username = username;
        }

        public void Update(MediaItem media)
        {
            Console.WriteLine($"Hello {_username}. You have received new notification: \n   New media was published - {media}");
        }
    }
}
