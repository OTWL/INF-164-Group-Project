using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static GroupProject.Global;

namespace GroupProject
{
    public partial class frmPlaylist : Form

    {

        public frmPlaylist()
        {
            InitializeComponent();
            LoadSelectedPlaylist();
        }

        //call user object to get id
        //ID is the tilte of the playlist
        string playlistId = Global.CurrentUser.GetSelectedPlaylistId();

        //Create the current playlist playlist get's assigned on init
        Playlist currentPlaylist;

        //Keep track if the back button is hit or the form is being closed to kill the hidden form
        //False at the start sa back button has not yet been pressed
        bool backButton = false;
        private string currentSongPath = "";

        // int numberOfTracks = 0;

        private void LoadSelectedPlaylist()
        {
            //Load PlayList information not DATA happens on form LOAD


            try
            {
                //We can check if it is null as we return null if none found
                if (!string.IsNullOrEmpty(playlistId))
                {
                    //Create the playlist object based of the object selected
                    currentPlaylist = Global.CurrentUser.GetPlaylistID(playlistId);
                    if (currentPlaylist != null)
                    {

                        //Set the labels of the name and the date of creation to the values from the playlist id
                        lblName.Text = currentPlaylist.GetTitle();
                        lblDateCreated.Text = currentPlaylist.GetDateOfCreation();

                        //Set's the current form name to name of the playlist
                        this.Text = "Playlist - " + currentPlaylist.GetTitle();

                        string imagePath = currentPlaylist.getCoverPath();

                        //Check if the image path exists - first checking if there is text in the string and
                        //then checking if the file is actually found at that location before trying to load it
                        if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                        {
                            //Dispose previous image if one exists to clear it and save some memory
                            if (picCoverArt.Image != null)
                            {
                                picCoverArt.Image.Dispose();
                            }

                            //load the cover art image path into the PictureBox
                            picCoverArt.Image = Image.FromFile(currentPlaylist.getCoverPath());

                            //If the image could be found load the defualt one
                        }
                        else
                        {
                            picCoverArt.Image = Properties.Resources.Default_Cover;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading playlist data:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //When the playlist loads
        private void UpdatePlaylist()
        {

            List<Song> songs = null;

            try
            {
                //Collect all songs in the playlist
                songs = currentPlaylist.GetSongs();
                dgvSongs.Rows.Clear();

                //Add all the songs into the data grid view
                foreach (Song song in songs)
                {
                    dgvSongs.Rows.Add(song.Title, song.Artist, song.Album, song.Genre, song.FilePath);
                }

                //After the DGV is populated update the record count
                updateNumberOfRecords();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No songs are added to the playlist yet");
            }

        }

        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            UpdatePlaylist();
        }

        private void btnSelectCoverImage_Click(object sender, EventArgs e)
        {
            //Select Cover Image

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string coverPath = openFileDialog.FileName;
                    picCoverArt.Image = Image.FromFile(coverPath);
                    //Set the image location aswell for the save function
                    picCoverArt.ImageLocation = openFileDialog.FileName;
                    //Enale button to save
                    BtnSaveCover.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load profile picture.\n\n" + ex.Message);
            }

        }

        private void BtnSaveCover_Click(object sender, EventArgs e)
        {
            //Button is disabled by defualt have to select an image to save on load


            if (string.IsNullOrEmpty(picCoverArt.ImageLocation) && string.IsNullOrEmpty(picCoverArt.Image.ToString()))
            {
                MessageBox.Show("Please select an image before saving");
                return;
            }

            //Save it to object
            currentPlaylist.SetCoverpath(picCoverArt.ImageLocation);
            Global.CurrentUser.SavePlaylistToDisk();

            MessageBox.Show("Playlist Cover Saved", "The album cover has been saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (BtnSaveCover.Enabled)
            {
                BtnSaveCover.Enabled = false;
            }
            else
            {
                BtnSaveCover.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backButton = true;
            this.Close();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Audio Files|*.mp3;*.wav";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] selectedSongs = openFileDialog.FileNames;

                foreach (string song in selectedSongs)
                {

                    //Create new form and show it
                    frmSongInfo saveForm = new frmSongInfo();
                    saveForm.ShowDialog();

                    if (!saveForm.SavedSuccessfully)
                    {
                        MessageBox.Show("Could not add song");
                        //No input for that song continue to next song
                        continue;
                    }

                    // Create new song object with values from the save form
                    Song mySong = new Song(saveForm.SongName, saveForm.SongArtist, saveForm.SongAlbum, saveForm.SongGenre, song);

                    if (currentPlaylist.AddSong(mySong))
                    {
                        dgvSongs.Rows.Add(mySong.Title, mySong.Artist, mySong.Album, mySong.Genre, mySong.FilePath);
                    }
                    else
                    {
                        MessageBox.Show("This song already exists in this playlist");
                    }
                }
                //Upadate label
                updateNumberOfRecords();
                //Save the playlist 
                Global.CurrentUser.SavePlaylistToDisk();

                //dgvSongs.Refresh();
            }
        }

        private void updateNumberOfRecords()
        {
            //Set text to current dgv count
            // -1 to account for the headers
            lblNumTracks.Text = "Number of tracks: " + Convert.ToString(dgvSongs.RowCount - 1);
        }

        private bool getCurrentSongFilePath(out string outfilepath)
        {

            //THERE IS A HIDDEN COLUM WITH THE FILE PATH, USER CANNOT EDIT IT OR SEE.

            //Get rid of magic/ambigous column number for readability
            const int FILEPATH = 4;

            //Get the file path of the currently selected row in the data grid view

            try
            {
                string filePath = dgvSongs.Rows[dgvSongs.CurrentRow.Index].Cells[FILEPATH].Value.ToString();
                outfilepath = filePath;
                return true;
            }
            catch
            {
                MessageBox.Show("Could not delete song");
            }

            outfilepath = null;
            return false;
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            //Find the song to be deleted pop it from the list save to disk

            //Can make it that it allows mutli song deletion

            string filePath = "";

            if (dgvSongs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a song to delete.");
                return;
            }


            //If we can get the current file continue else do not continue
            if (getCurrentSongFilePath(out filePath))
            {
                foreach (Song song in currentPlaylist.GetSongs())
                {
                    //Loop thourg the users songs
                    //If given song == a songs file path give back that object
                    // File Paths are identifiers and are unique
                    if (song.FilePath == filePath)
                    {
                        MessageBox.Show(song.Title + " " + song.FilePath);
                        //We have the song object now
                        currentPlaylist.Remove(song);
                        break;
                    }

                }
                UpdatePlaylist();
                Global.CurrentUser.SavePlaylistToDisk();
            }
        }

        private void btnPlaySong_Click(object sender, EventArgs e)
        {

            string outfilepath = "";

            // If we could find the song
            if (getCurrentSongFilePath(out outfilepath))
            {
                // Only load the song if it is a different song
                if (currentSongPath != outfilepath)
                {
                    currentSongPath = outfilepath;
                    mediaPlayer.URL = outfilepath;
                }

                mediaPlayer.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Could not find selected song to play");
                return;
            }

        }

        private void frmPlaylist_FormClosed(object sender, FormClosedEventArgs e)
        {
            //If back button was clicked do NOT run this code
            if (!backButton)
            {
                Application.Exit();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.pause();
        }

        private void dgvSongs_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            dgvSongs.Columns[columnIndex].SortMode = DataGridViewColumnSortMode.Automatic;
        }
    }
}