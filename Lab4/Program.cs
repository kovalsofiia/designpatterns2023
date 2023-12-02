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

            var user1 = new User("StudentA");
            var user2 = new User("StudentB");

            user1.Subscribe(mediaPublisher, "programming");
            user2.Subscribe(mediaPublisher, "study");

            mediaPublisher.PublishMedia(new Photo
            {
                AuthorNick = "PhotographerStudent",
                Title = "Brainstorming Session",
                Description = "Students collaborating on a creative project",
                Url = "https://example.com/brainstorming",
                Width = 1200,
                Height = 800
            });

            mediaPublisher.PublishMedia(new Video
            {
                AuthorNick = "VideographerStudent",
                Title = "Study Break Fun",
                Description = "Students taking a break and having fun in the campus courtyard",
                Url = "https://example.com/fun-break",
                DurationSeconds = 180
            });

            user1.Unsubscribe(mediaPublisher);

            mediaPublisher.PublishMedia(new Photo
            {
                AuthorNick = "StudentPhotographer",
                Title = "Late Night Coding",
                Description = "A student working on a programming assignment late into the night",
                Url = "https://example.com/late-night-coding",
                Width = 1600,
                Height = 1200
            });
        }
    }
}

