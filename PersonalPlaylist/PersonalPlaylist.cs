using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalPlaylist
{
    public partial class PersonalPlaylist : Form
    {
        List<Song> songs = new List<Song>();

        List<Artist> artists = new List<Artist>();



        public PersonalPlaylist()
        {
            InitializeComponent();

            LoadSongsList();

            LoadArtistsList();
        }

        //SongsList
        private void LoadSongsList()
        {
            if (radioAll.Checked)
            {
                songs = SqliteDataAccess.GetSongs();


            }else if(radioSearchYear.Checked){

                songs = SqliteDataAccess.GetSongsbyYear(textYear.Text);
            }
            else if (radioArtistFilter.Checked)
            {
                songs = SqliteDataAccess.GetSongs(listDisplayArtists.SelectedValue.ToString());
            }else if (radioSearch.Checked)
            {
                songs = SqliteDataAccess.SearchSongs(textSearch.Text);
            }
            WireUpSongsList();
        }

        private void WireUpSongsList()
        {
            listSongs.DataSource = null;
            listSongs.DataSource = songs;
            listSongs.DisplayMember = "DisplayInListView";
            listSongs.ValueMember = "Id";

        }



        //ArtistsList
        private void LoadArtistsList()
        {
            artists = SqliteDataAccess.GetArtists();

            WireUpArtistsList();
        }

        private void WireUpArtistsList()
        {
            listArtists.DataSource = null;
            listArtists.DataSource = artists;
            listArtists.DisplayMember = "Name";

            dropSongArtist.DataSource = null;
            dropSongArtist.DataSource = artists;
            dropSongArtist.DisplayMember = "Name";
            dropSongArtist.ValueMember = "Id";

            listDisplayArtists.DataSource = null;
            listDisplayArtists.DataSource = artists;
            listDisplayArtists.DisplayMember = "Name";
            listDisplayArtists.ValueMember = "Id";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PersonalPlaylist_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddSong_Click(object sender, EventArgs e)
        {
            if (textSongTitle.Text != "" && textSongYear.Text != "")
            {
                try
                {
                    string ot = textSongTitle.Text;

                    Song song = new Song(ot, long.Parse(textSongYear.Text), long.Parse(dropSongArtist.SelectedValue.ToString()));
                    SqliteDataAccess.AddSong(song);
                    textSongTitle.Text = null;
                    textSongYear.Text = null;
                    
                    LoadSongsList();
                    MessageBox.Show($"{ot} has been added to the songs list.");
                }
                catch
                {
                    MessageBox.Show("There's an error adding a new song to the list.");
                }


            }
            else
            {
                MessageBox.Show("Adding an empty data is not allowed.");

            }
        }

        private void buttonArtistAdd_Click(object sender, EventArgs e)
        {
            if (textArtistName.Text != "")
            {
                long id = new long();
                string ot = textArtistName.Text;
                textArtistName.Text = null;
                Artist artist = new Artist(id, ot);

                try
                {
                    SqliteDataAccess.AddArtist(artist);
                    LoadArtistsList();


                    MessageBox.Show($"{ot} has been added to the artists list.");


                }
                catch
                {
                    MessageBox.Show($"There's an error adding {ot} into the database.");
                }
            }
            else
            {
                MessageBox.Show("Adding an empty data is not allowed.");
            }
        }

        private void buttonArtistRemove_Click(object sender, EventArgs e)
        {
            string ot = listArtists.Text;
            SqliteDataAccess.RemoveArtist(ot);
            LoadArtistsList();
            LoadSongsList();
            MessageBox.Show($"\"{ot}\" has been deleted.");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //Remove a song
        private void button6_Click(object sender, EventArgs e)
        {
            string ot = listSongs.SelectedValue.ToString();
            string songName = listSongs.Text;
            SqliteDataAccess.RemoveSong(long.Parse(ot));
            LoadSongsList();
            MessageBox.Show($"{songName} has been deleted.");

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            LoadSongsList();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            radioSearch.Checked = true;
        }

        private void textSearch_MouseClick(object sender, MouseEventArgs e)
        {
            radioSearch.Checked = true;
            
        }

        private void listDisplayArtists_MouseClick(object sender, MouseEventArgs e)
        {
            radioArtistFilter.Checked = true;
        }

        private void radioSearch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioSearch_Click(object sender, EventArgs e)
        {
            textSearch.Focus();
        }

        private void radioSearchYear_Click(object sender, EventArgs e)
        {
            textYear.Focus();
        }

        private void textYear_Click(object sender, EventArgs e)
        {
            radioSearchYear.Checked = true;

        }

        private void textYear_TextChanged(object sender, EventArgs e)
        {
            radioSearchYear.Checked = true;
        }

        private void listArtists_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            radioArtistFilter.Checked=true;
            buttonDisplay_Click(sender,e);
                
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void listArtists_Click(object sender, EventArgs e)
        {
            radioArtistFilter.Checked = true;
            buttonDisplay_Click(sender, e);
        }

        private void listArtists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void buttonDisplayAll_Click(object sender, EventArgs e)
        {
            songs = SqliteDataAccess.GetSongs();
            WireUpSongsList();
        }

        private void listSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioArtistFilter_Click(object sender, EventArgs e)
        {
            listDisplayArtists.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://aspiyawit.github.io/");
            Process.Start(sInfo);
        }
    }
}
