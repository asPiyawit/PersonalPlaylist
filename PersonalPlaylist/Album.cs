using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPlaylist
{
    public class Album
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long Year { get; set; }
        public long ArtistId { get; set; }
        public Album(long id, string title, long year,long artistid)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.ArtistId = artistid;
        }
    }
}
