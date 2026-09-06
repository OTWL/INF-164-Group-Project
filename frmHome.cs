using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            //Populate list box on load
            LoadUserPlaylists();
            greetings();
            //Load as defualt
            picAlbum.Image = Properties.Resources.Default_Cover;
            LoadProfilePic();
        }
        private void greetings()
        {
            string[] greetmessages = { "Welcome", "Howzit", "What's the vibe today", "Awe" };
            Random numbergenerator = new Random();
            int index = numbergenerator.Next(0, greetmessages.Length);
            lblWelcome.Text = greetmessages[index] + ", " + Global.CurrentUser.Username;

        }
        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GoToPlaylist()
        {
            //Go to PlayList Page

            try
            {
                //control name for listbox should be lstPlaylists
                //Fixed
                if (lstPlaylists.SelectedItem != null)
                {
                    string selectedLine = lstPlaylists.SelectedItem.ToString();
                    string[] playlistDetails = selectedLine.Split('-');


                    if (playlistDetails.Length > 0)
                    {
                        //Trim to remove whitespace
                        string playlistId = playlistDetails[0].Trim();

                        //Set current selected playlist 
                        Global.CurrentUser.setSelectedPlaylistId(playlistId);

                        //open playlist form
                        frmPlaylist playlistForm = new frmPlaylist();

                        this.Hide();
                        playlistForm.ShowDialog();
                        this.Show();
                    }


                }
                else
                {
                    MessageBox.Show("Please select a playlist to open.", "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnGoToPlaylist_Click(object sender, EventArgs e)
        {
            GoToPlaylist();
        }

        private void LoadUserPlaylists()
        {
            //Loads and filters playlists for logged in user into mPlaylist
            Global.CurrentUser.GetPlaylists();
            //Forgot to push this to main
            //Gets only playlists created by current user
            List<Global.Playlist> PlayLists = Global.CurrentUser.mUserPlaylist;
            //MABE AN ERROR IF THERE IS NO PLAYLISTS

            //Loop over list
            foreach (Global.Playlist p in PlayLists)
            {
                lstPlaylists.Items.Add(p.GetTitle() + " - Created: " + p.GetDateOfCreation());
            }
        }

        private void LoadProfilePic()
        {

            try
            {
                string path = Global.CurrentUser.ProfilePath;

                //If path is default set to defualt image
                if (string.IsNullOrEmpty(path) || path == "Default Image")
                {
                    picProfile.Image = Properties.Resources.Default_Image;
                    return;
                }
                picProfile.Image = Image.FromFile(path);
            }
            catch (Exception)
            {
                //path exists but is not a valid image so we go back to default image
                picProfile.Image = Properties.Resources.Default_Image;

            }




        }

        private void lstPlaylists_DoubleClick(object sender, EventArgs e)
        {
            GoToPlaylist();
        }

        private void lstPlaylists_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                int index = lstPlaylists.SelectedIndex;
                string path = Global.CurrentUser.GetCoverPathByIndex(index);

                picAlbum.Image = Image.FromFile(path);
            }
            catch (Exception)
            {
                picAlbum.Image = Properties.Resources.Default_Cover;
            }
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            //LEAVE ART PATH EMPTY FOR NOW
            //ADD VALIDATION
            Global.Playlist newPlaylist = new Global.Playlist(title, "", Global.CurrentUser.Username);
            lstPlaylists.Items.Add(newPlaylist.GetTitle() + " - Created: " + newPlaylist.GetDateOfCreation());
            Global.CurrentUser.SaveNewPlaylist(newPlaylist);
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            // Make sure the user has selected at least one playlist
            if (lstPlaylists.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one playlist.");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio Files|*.mp3;*.wav";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Store actual playlist objects selected by user
                List<Global.Playlist> selectedPlaylists = new List<Global.Playlist>();

                //Gets all playlists currently stores
                List<Global.Playlist> allPlaylists = Global.CurrentUser.GetPlaylists();

                //Go through every playlist selected
                foreach (var selectedItem in lstPlaylists.SelectedItems)
                {
                    string selectedLine = selectedItem.ToString();
                    string[] playlistDetails = selectedLine.Split('-');
                    string playlistId = playlistDetails[0].Trim();

                    //Finds playlist object with this title
                    Global.Playlist playlist = allPlaylists.FirstOrDefault(p => p.GetTitle() == playlistId);


                    if (playlist != null)
                    {
                        selectedPlaylists.Add(playlist);
                    }
                }

                string[] selectedSongs = openFileDialog.FileNames;

                // Go through each selected audio file
                foreach (string song in selectedSongs)
                {
                    // TEMPORARY: Replace with song details from the UI once the textboxes are added
                    Global.Song mySong = new Global.Song("Test Song", "Test Artist", "Test Album", "Test Genre", song);

                    // Add the same Song object to every selected playlist
                    foreach (Global.Playlist playlist in selectedPlaylists)
                    {
                        playlist.AddSong(mySong);
                    }
                }

                Global.CurrentUser.SavePlaylistToDisk();
            }
        }
    }
}
