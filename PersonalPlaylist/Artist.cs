using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPlaylist
{
    public class Artist
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Artist(long id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}
