using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Video:MediaItem
    {
        public int DurationSeconds { get; set; }

        public override string ToString()
        {
            return $"\n-----Video: \n{Title} by {AuthorNick} ({DurationSeconds} seconds) - {Description} ({Url})";
        }
    }
}
