using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using Dapper;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalPlaylist
{
    public class SqliteDataAccess
    {
        // Songs
        public static List<Song> GetSongs()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Song>("select * from Songs order by Title asc");
                return output.ToList();
                
            }
        }
        public static List<Song> GetSongs(string artistid)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Song>($"select * from Songs where ArtistID='{artistid}' order by Title asc ");
                return output.ToList();

            }
        }
        public static List<Song> SearchSongs(string keyword)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Song>($"select * from Songs where Title like '%{keyword}%' order by Title asc ");
                return output.ToList();

            }
        }
        public static List<Song> GetSongsbyYear(string year)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Song>($"select * from Songs where Year = '{year}' order by Title asc ");
                return output.ToList();

            }
        }
        public static void AddSong(Song song)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Songs (Title,Year,ArtistId) values (@Title,@Year,@ArtistId)", song);
            }
        }
        public static void RemoveSong(long id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"delete from Songs where Id='{id}'");
            }
        }

        // Artists

        public static List<Artist> GetArtists()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Artist>("select * from Artists order by Name asc");
                return output.ToList();

            }
        }
       //select single object
        public static Artist GetArtistNameUsingId(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Artist>($"select * from Artists where Id='{id}'");
                return output.FirstOrDefault() ;

            }
        }

        public static void AddArtist(Artist artist)
        {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {


                    cnn.Execute("insert into Artists (Name) values (@Name)", artist);

                }
            
            
        }
        public static void RemoveArtist(string name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"delete from Artists where Name='{name}'");
            }
        }




        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
