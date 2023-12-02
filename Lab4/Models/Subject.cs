using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Subject : ISubject
    {
        private List<IObserver> _subscribers = new List<IObserver>();
        private List<MediaItem> _mediaItems = new List<MediaItem>();

        
        public void Attach(IObserver observer)
        {
            _subscribers.Add(observer);
        }

        
        public void Detach(IObserver observer)
        {
            _subscribers.Remove(observer);
        }

       
        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(_mediaItems.Last());
            }
        }

        public void PublishMedia(MediaItem media)
        {
            _mediaItems.Add(media);
            Console.WriteLine($"\n\n\nPublished new media: {media}");
            Notify();
        }
    }
}
