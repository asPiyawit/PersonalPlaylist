
namespace PersonalPlaylist
{
    partial class PersonalPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalPlaylist));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioSearch = new System.Windows.Forms.RadioButton();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.radioArtistFilter = new System.Windows.Forms.RadioButton();
            this.listDisplayArtists = new System.Windows.Forms.ComboBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textYear = new System.Windows.Forms.TextBox();
            this.radioSearchYear = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textArtistName = new System.Windows.Forms.TextBox();
            this.buttonArtistAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonArtistRemove = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSongAdd = new System.Windows.Forms.Button();
            this.textSongTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textSongYear = new System.Windows.Forms.TextBox();
            this.dropSongArtist = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listSongs = new System.Windows.Forms.ListBox();
            this.listArtists = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.labelArtistList = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(638, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Songs List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(389, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Artists List";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Checked = true;
            this.radioAll.Location = new System.Drawing.Point(13, 39);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(123, 21);
            this.radioAll.TabIndex = 6;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "Show all songs";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioSearch
            // 
            this.radioSearch.AutoSize = true;
            this.radioSearch.Location = new System.Drawing.Point(14, 112);
            this.radioSearch.Name = "radioSearch";
            this.radioSearch.Size = new System.Drawing.Size(264, 21);
            this.radioSearch.TabIndex = 7;
            this.radioSearch.Text = "Only songs that contain this keyword:";
            this.radioSearch.UseVisualStyleBackColor = true;
            this.radioSearch.CheckedChanged += new System.EventHandler(this.radioSearch_CheckedChanged);
            this.radioSearch.Click += new System.EventHandler(this.radioSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(13, 139);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(263, 22);
            this.textSearch.TabIndex = 8;
            this.textSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textSearch_MouseClick);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // radioArtistFilter
            // 
            this.radioArtistFilter.AutoSize = true;
            this.radioArtistFilter.Location = new System.Drawing.Point(14, 176);
            this.radioArtistFilter.Name = "radioArtistFilter";
            this.radioArtistFilter.Size = new System.Drawing.Size(129, 21);
            this.radioArtistFilter.TabIndex = 9;
            this.radioArtistFilter.Text = "Only from artist:";
            this.radioArtistFilter.UseVisualStyleBackColor = true;
            this.radioArtistFilter.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.radioArtistFilter.Click += new System.EventHandler(this.radioArtistFilter_Click);
            // 
            // listDisplayArtists
            // 
            this.listDisplayArtists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listDisplayArtists.FormattingEnabled = true;
            this.listDisplayArtists.Location = new System.Drawing.Point(144, 173);
            this.listDisplayArtists.Name = "listDisplayArtists";
            this.listDisplayArtists.Size = new System.Drawing.Size(133, 24);
            this.listDisplayArtists.TabIndex = 10;
            this.listDisplayArtists.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listDisplayArtists_MouseClick);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplay.Location = new System.Drawing.Point(13, 213);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(267, 52);
            this.buttonDisplay.TabIndex = 11;
            this.buttonDisplay.Text = "Display with set conditions above";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textYear);
            this.panel1.Controls.Add(this.radioSearchYear);
            this.panel1.Controls.Add(this.radioSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioAll);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.radioArtistFilter);
            this.panel1.Controls.Add(this.listDisplayArtists);
            this.panel1.Controls.Add(this.buttonDisplay);
            this.panel1.Location = new System.Drawing.Point(960, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 276);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "*2*";
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(141, 75);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(135, 22);
            this.textYear.TabIndex = 13;
            this.textYear.Click += new System.EventHandler(this.textYear_Click);
            this.textYear.TextChanged += new System.EventHandler(this.textYear_TextChanged);
            // 
            // radioSearchYear
            // 
            this.radioSearchYear.AutoSize = true;
            this.radioSearchYear.Location = new System.Drawing.Point(13, 75);
            this.radioSearchYear.Name = "radioSearchYear";
            this.radioSearchYear.Size = new System.Drawing.Size(122, 21);
            this.radioSearchYear.TabIndex = 12;
            this.radioSearchYear.TabStop = true;
            this.radioSearchYear.Text = "Only from year";
            this.radioSearchYear.UseVisualStyleBackColor = true;
            this.radioSearchYear.Click += new System.EventHandler(this.radioSearchYear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(84, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Display Options";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textArtistName);
            this.panel2.Controls.Add(this.buttonArtistAdd);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(337, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 276);
            this.panel2.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(261, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "*1*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Artist\'s Name";
            // 
            // textArtistName
            // 
            this.textArtistName.ForeColor = System.Drawing.Color.OrangeRed;
            this.textArtistName.Location = new System.Drawing.Point(49, 128);
            this.textArtistName.Name = "textArtistName";
            this.textArtistName.Size = new System.Drawing.Size(187, 22);
            this.textArtistName.TabIndex = 2;
            // 
            // buttonArtistAdd
            // 
            this.buttonArtistAdd.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonArtistAdd.Location = new System.Drawing.Point(92, 156);
            this.buttonArtistAdd.Name = "buttonArtistAdd";
            this.buttonArtistAdd.Size = new System.Drawing.Size(108, 41);
            this.buttonArtistAdd.TabIndex = 1;
            this.buttonArtistAdd.Text = "Add Artist";
            this.buttonArtistAdd.UseVisualStyleBackColor = false;
            this.buttonArtistAdd.Click += new System.EventHandler(this.buttonArtistAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(96, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Add an Artist";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonArtistRemove
            // 
            this.buttonArtistRemove.BackColor = System.Drawing.Color.Crimson;
            this.buttonArtistRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonArtistRemove.Location = new System.Drawing.Point(498, 18);
            this.buttonArtistRemove.Name = "buttonArtistRemove";
            this.buttonArtistRemove.Size = new System.Drawing.Size(135, 43);
            this.buttonArtistRemove.TabIndex = 6;
            this.buttonArtistRemove.Text = "Remove the artist";
            this.buttonArtistRemove.UseVisualStyleBackColor = false;
            this.buttonArtistRemove.Click += new System.EventHandler(this.buttonArtistRemove_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.buttonSongAdd);
            this.panel4.Controls.Add(this.textSongTitle);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.textSongYear);
            this.panel4.Controls.Add(this.dropSongArtist);
            this.panel4.Location = new System.Drawing.Point(642, 312);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(312, 276);
            this.panel4.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "*1*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(111, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Add a Song";
            // 
            // buttonSongAdd
            // 
            this.buttonSongAdd.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonSongAdd.Location = new System.Drawing.Point(93, 188);
            this.buttonSongAdd.Name = "buttonSongAdd";
            this.buttonSongAdd.Size = new System.Drawing.Size(131, 41);
            this.buttonSongAdd.TabIndex = 1;
            this.buttonSongAdd.Text = "Add Song";
            this.buttonSongAdd.UseVisualStyleBackColor = false;
            this.buttonSongAdd.Click += new System.EventHandler(this.buttonAddSong_Click);
            // 
            // textSongTitle
            // 
            this.textSongTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.textSongTitle.Location = new System.Drawing.Point(66, 83);
            this.textSongTitle.Name = "textSongTitle";
            this.textSongTitle.Size = new System.Drawing.Size(187, 22);
            this.textSongTitle.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Song\'s Title";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Artist";
            // 
            // textSongYear
            // 
            this.textSongYear.ForeColor = System.Drawing.Color.DarkBlue;
            this.textSongYear.Location = new System.Drawing.Point(28, 141);
            this.textSongYear.Name = "textSongYear";
            this.textSongYear.Size = new System.Drawing.Size(72, 22);
            this.textSongYear.TabIndex = 5;
            // 
            // dropSongArtist
            // 
            this.dropSongArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropSongArtist.ForeColor = System.Drawing.Color.DarkBlue;
            this.dropSongArtist.FormattingEnabled = true;
            this.dropSongArtist.Location = new System.Drawing.Point(106, 141);
            this.dropSongArtist.Name = "dropSongArtist";
            this.dropSongArtist.Size = new System.Drawing.Size(173, 24);
            this.dropSongArtist.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(1118, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "Remove the song";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label12.Location = new System.Drawing.Point(11, 568);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "Created using C# by Piyawit Prompradit";
            // 
            // listSongs
            // 
            this.listSongs.BackColor = System.Drawing.Color.LightCyan;
            this.listSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listSongs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 22;
            this.listSongs.Location = new System.Drawing.Point(642, 65);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(615, 246);
            this.listSongs.TabIndex = 15;
            this.listSongs.SelectedIndexChanged += new System.EventHandler(this.listSongs_SelectedIndexChanged);
            // 
            // listArtists
            // 
            this.listArtists.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.listArtists.ForeColor = System.Drawing.Color.OrangeRed;
            this.listArtists.FormattingEnabled = true;
            this.listArtists.ItemHeight = 26;
            this.listArtists.Location = new System.Drawing.Point(337, 123);
            this.listArtists.Name = "listArtists";
            this.listArtists.Size = new System.Drawing.Size(293, 186);
            this.listArtists.TabIndex = 15;
            this.listArtists.SelectedIndexChanged += new System.EventHandler(this.listArtists_SelectedIndexChanged);
            this.listArtists.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listArtists_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(26, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 323);
            this.label7.TabIndex = 17;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(26, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Instructions";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(33, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(228, 29);
            this.label14.TabIndex = 19;
            this.label14.Text = "My Personal Playlist";
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonDisplayAll.Location = new System.Drawing.Point(539, 65);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(94, 55);
            this.buttonDisplayAll.TabIndex = 20;
            this.buttonDisplayAll.Text = "Display all songs";
            this.buttonDisplayAll.UseVisualStyleBackColor = false;
            this.buttonDisplayAll.Click += new System.EventHandler(this.buttonDisplayAll_Click);
            // 
            // labelArtistList
            // 
            this.labelArtistList.AutoSize = true;
            this.labelArtistList.ForeColor = System.Drawing.Color.Black;
            this.labelArtistList.Location = new System.Drawing.Point(334, 66);
            this.labelArtistList.Name = "labelArtistList";
            this.labelArtistList.Size = new System.Drawing.Size(198, 51);
            this.labelArtistList.TabIndex = 21;
            this.labelArtistList.Text = "Double clicking on a particular\r\nitem below to display each \r\nartist\'s songs";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1089, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "*3*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(469, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 17);
            this.label18.TabIndex = 14;
            this.label18.Text = "*3*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label19.Location = new System.Drawing.Point(28, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(259, 54);
            this.label19.TabIndex = 22;
            this.label19.Text = "**This is basically just for \r\nproving my general knowledge\r\nabout DATABASE";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.linkLabel1.Location = new System.Drawing.Point(11, 591);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 20);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "My Brief Profile";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label20.ForeColor = System.Drawing.Color.OrangeRed;
            this.label20.Location = new System.Drawing.Point(505, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 38);
            this.label20.TabIndex = 24;
            this.label20.Text = "☟";
            // 
            // PersonalPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1273, 622);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelArtistList);
            this.Controls.Add(this.buttonDisplayAll);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonArtistRemove);
            this.Controls.Add(this.listArtists);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listSongs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonalPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Personal Playlist";
            this.Load += new System.EventHandler(this.PersonalPlaylist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.RadioButton radioArtistFilter;
        private System.Windows.Forms.ComboBox listDisplayArtists;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textArtistName;
        private System.Windows.Forms.Button buttonArtistAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonArtistRemove;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textSongYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSongTitle;
        private System.Windows.Forms.Button buttonSongAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox dropSongArtist;
        private System.Windows.Forms.ListBox listSongs;
        private System.Windows.Forms.ListBox listArtists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioSearchYear;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.Label labelArtistList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label20;
    }
}

