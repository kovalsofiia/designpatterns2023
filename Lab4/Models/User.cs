using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class User: IObserver
    {
        public string Username { get; }

        public User(string username)
        {
            Username = username;
        }

        
        public void Update(MediaItem media)
        {
            Console.WriteLine($"{Username} received notification: New media - {media}");
        }

 
        public void Subscribe(Subject publisher, string keyword = "")
        {
            publisher.Attach(this);
            if (!string.IsNullOrEmpty(keyword))
            {
                Console.WriteLine($"{Username} subscribed to media with keyword: {keyword}");
            }
            else
            {
                Console.WriteLine($"{Username} subscribed to all media");
            }
        }

        
        public void Unsubscribe(Subject publisher)
        {
            publisher.Detach(this);
            Console.WriteLine($"{Username} unsubscribed");
        }
    }
}
