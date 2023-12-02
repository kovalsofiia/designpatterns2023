using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _latestMedia;

     
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }


        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

       
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_latestMedia);
            }
        }

        
        public void PublishMedia(string media)
        {
            _latestMedia = media;
            Console.WriteLine($":\n:\n:\n(Information message)New media was published: {_latestMedia}\n");
            Notify();
        }
    }
}
