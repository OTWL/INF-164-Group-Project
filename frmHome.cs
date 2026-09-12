using System;
using System.Collections.Generic;
using System.Drawing;
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

            //Create a 2d array which houses both messages adn weights of those messages
            string[,] greetMessagesAndWeight = new string[,] {
           //Col: 0         1
/*Row: 0*/      { "Welcome", "0.4"},
                { "Howzit","0.2" },
                { "What's the vibe today", "0.1"},
                { "Awe", "0.3" }
            };

            Random numbergenerator = new Random();

            //Get number between 0 and 1
            double generatedNumber = numbergenerator.NextDouble();

            int index = 0;

            //Running total to calcuate where it lies
            double runningTotal = 0;

            //Loop thougth the total sum of the ranges
            //0.6 < 0.4 X
            //0.6 < 0.6 X
            //0.6 < 0.7 ✓
            //message == What's the vibe today 
            for (int i = 0; i < greetMessagesAndWeight.GetLength(0); i++)
            {
                //Increase running total to account for new weight section
                //0.4 -> 0.6
                runningTotal += Convert.ToDouble(greetMessagesAndWeight[i, 1]);

                //If it fits into a section
                if (generatedNumber < runningTotal)
                {
                    index = i;
                    //Stop looking
                    break;
                }

            }

            //NOT [1,Index] as that display the weight
            //Selected row and col 0 which is the messages
            lblWelcome.Text = greetMessagesAndWeight[index, 0] + ", " + Global.CurrentUser.Username;

        }

        public void CalculateStats()
        {
            //1. calculate total playlists 
            //count number of playlists currently loaded into the users list 
            int totalPlaylists = Global.CurrentUser.mUserPlaylist.Count;
            lblTotalPlaylists.Text = "Total Playlists: " + totalPlaylists.ToString();

            Global.CurrentUser.populateUserSongs();

            //to check if the user has any songs in their library before calculating
            if (Global.CurrentUser.mSongs.Count > 0)
            {
                //2. calculate total songs 
                int totalSongs = Global.CurrentUser.mSongs.Count;
                lblTotalSongs.Text = "Total Tracks: " + totalSongs.ToString();

                //3. calculate top artist 

                string topArtist = "No songs yet!";
                int highestCount = 0;

                //outer loop will pick one song at a time to check its artist 
                for (int i = 0; i < Global.CurrentUser.mSongs.Count; i++)
                {
                    string currentArtist = Global.CurrentUser.mSongs[i].Artist;
                    int currentArtistCount = 0;

                    //inner loop will scan through the whole list and count how many times
                    //the artist appears 
                    for (int j = 0; j < Global.CurrentUser.mSongs.Count; j++)
                    {
                        if (Global.CurrentUser.mSongs[j].Artist == currentArtist)
                        {
                            currentArtistCount++;
                        }
                    }

                    //if this artist has more tracks than our previous highest , they take the top spot
                    if (currentArtistCount > highestCount)
                    {
                        highestCount = currentArtistCount;
                        topArtist = currentArtist;
                    }

                }
                lblTopArtist.Text = "Top Artist: " + topArtist;
            }
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
            List<Playlist> PlayLists = Global.CurrentUser.mUserPlaylist;
            //MABE AN ERROR IF THERE IS NO PLAYLISTS

            //Loop over list
            foreach (Playlist p in PlayLists)
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
            Playlist newPlaylist = new Playlist(title, "", Global.CurrentUser.Username);
            lstPlaylists.Items.Add(newPlaylist.GetTitle() + " - Created: " + newPlaylist.GetDateOfCreation());
            Global.CurrentUser.SaveNewPlaylist(newPlaylist);
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {

            //CHECK IF THE FILE PATH IS ALREADY IN THIS USRERS PlAYLIST
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
                List<Playlist> selectedPlaylists = new List<Playlist>();

                //Gets all playlists currently stores
                List<Playlist> allPlaylists = Global.CurrentUser.GetPlaylists();

                //Go through every playlist selected
                foreach (var selectedItem in lstPlaylists.SelectedItems)
                {
                    string selectedLine = selectedItem.ToString();
                    string[] playlistDetails = selectedLine.Split('-');
                    string playlistId = playlistDetails[0].Trim();

                    //Finds playlist object with this title

                    //Create empty playlist object
                    Playlist playlist = null;

                    foreach (Playlist p in allPlaylists)
                    {
                        //Look if current plalist == playlist id and belongs to the user
                        if (p.GetTitle() == playlistId && p.Username == Global.CurrentUser.Username)
                        {
                            //Return it and stop searching
                            playlist = p;
                            break;
                        }
                    }

                    //Found playlist add it to selected playlist list
                    if (playlist != null)
                    {
                        //Add it to selected playlist
                        selectedPlaylists.Add(playlist);
                    }
                }

                string[] selectedSongs = openFileDialog.FileNames;

                // Go through each selected audio file
                foreach (string song in selectedSongs)
                {
                    //Create new form and save it
                    frmSongInfo saveForm = new frmSongInfo();
                    saveForm.ShowDialog();

                    // Create new song object
                    Song mySong = new Song(saveForm.SongName, saveForm.SongArtist, saveForm.SongAlbum, saveForm.SongGenre, song);

                    // Add the same Song object to every selected playlist
                    foreach (Playlist playlist in selectedPlaylists)
                    {
                        playlist.AddSong(mySong);
                    }
                }

                Global.CurrentUser.SavePlaylistToDisk();
            }
        }

        private void btnDeletePlaylists_Click(object sender, EventArgs e)
        {
            //Only delete one playlist at a time
            if (lstPlaylists.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select one playlist to delete.");
                return;
            }

            //Get the selected playlist
            int selectedIndex = lstPlaylists.SelectedIndex;
            Playlist playlistToDelete = Global.CurrentUser.mUserPlaylist[selectedIndex];

            //Ask the user for confirmation
            DialogResult answer = MessageBox.Show($"Are you sure you want to delete the playlist '{playlistToDelete.GetTitle()}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (answer == DialogResult.Yes)
            {
                //Delete and save the playlist
                Global.CurrentUser.DeletePlaylist(playlistToDelete);

                //Remove the playlist from the ListBox
                lstPlaylists.Items.RemoveAt(selectedIndex);

                //Reset the cover picture and update stats
                picAlbum.Image = Properties.Resources.Default_Cover;
                CalculateStats();

                MessageBox.Show("Playlist deleted successfully.");
            }
        }


        private void frmHome_Load(object sender, EventArgs e)
        {
            CalculateStats();
        }

        private void frmHome_Shown(object sender, EventArgs e)
        {
            CalculateStats();
        }
    }
}
