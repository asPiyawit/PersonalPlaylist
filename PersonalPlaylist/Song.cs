using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPlaylist
{
    public class Song
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long Year { get; set; }
        public long ArtistId { get; set; }
        Artist artist;

        public Song(long id, string title, long year, long artistid)
        {
            this.Id = id;
            this.Title = title;
            this.Year = year;
            this.ArtistId = artistid;
            artist = SqliteDataAccess.GetArtistNameUsingId(this.ArtistId.ToString());

        }
        public Song(string title, long year, long artistid)
        {

            this.Title = title;
            this.Year = year;
            this.ArtistId = artistid;


        }

        public string DisplayInListView
        {
            get
            {
                if (artist==null)
                {
                    return $"{this.Title} [{this.Year}] by <UnknownArtist>";
                }
                else
                {
                    return $"{this.Title} [{this.Year}] by <{this.artist.Name.ToString()}>";
                }
                
                    
            }
        }



    }
}
