using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Photo : MediaItem
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"\n-----Photo: \n{Title} by {AuthorNick} ({Width}x{Height}) - {Description} ({Url})";
        }
    }
}
