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
        //Create the current playlistt playlist 
        Global.Playlist currentPlaylist;

        private string currentSongPath = "";

        // int numberOfTracks = 0;

        private void LoadSelectedPlaylist()
        {
            try
            {
                //We can check if it is null as we return null if none found
                if (!string.IsNullOrEmpty(playlistId))
                {
                    //Create the playlist object based of the object selected
                    currentPlaylist = Global.CurrentUser.GetPlaylistID(playlistId);

                    //Set the labels of the name and the date of creation to the values from the playlist id
                    lblName.Text = currentPlaylist.GetTitle();
                    lblDateCreated.Text = currentPlaylist.GetDateOfCreation();

                    if (currentPlaylist != null)
                    {
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
            //Collect all songs in the playlist
            List<Song> songs = currentPlaylist.GetSongs();
            dgvSongs.Rows.Clear();

            if (songs == null)
            {

                MessageBox.Show("No songs could be found!");
                return;
            }

            //Add all the songs into the data grid view
            foreach (Song song in songs)
            {
                dgvSongs.Rows.Add(song.Title, song.Artist, song.Album, song.Genre, song.FilePath);
            }

            //After the DGV is populated update the record count
            updateNumberOfRecords();
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
                    // TEMPORARY: Replace with song details from the UI once the textboxes are added
                    //Create new form and save it
                    frmSongInfo saveForm = new frmSongInfo();
                    saveForm.ShowDialog();

                    // Create new song object
                    Global.Song mySong = new Global.Song(saveForm.SongName, saveForm.SongArtist, saveForm.SongAlbum, saveForm.SongGenre, song);


                    //Add the song to the current playlist
                    currentPlaylist.AddSong(mySong);

                    //Display the newly added song in the DataGridView
                    dgvSongs.Rows.Add(mySong.Title, mySong.Artist, mySong.Album, mySong.Genre, mySong.FilePath);

                }
                //Upadate label
                updateNumberOfRecords();
                //Save the playlist 
                Global.CurrentUser.SavePlaylistToDisk();
            }
        }

        private void updateNumberOfRecords()
        {
            //CAN ADD 2D array here
            //Set text to current dgv count
            // -1 to account for the headers
            lblNumTracks.Text = "Number of tracks: " + Convert.ToString(dgvSongs.RowCount - 1);
        }

        private bool getCurrentSongFilePath(out string outfilepath)
        {

            //THER IS A HIDDEN COLUM WITH THE FILE PATH, USER CANNOT EDIT IT OR SEE.

            //Get rid of magic/ambigous column number
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

            outfilepath = "";
            return false;
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            //Find the song to be deleted pop it from the list save to disk

            //Can make it that it allows mutli song deletion

            string filePath = "";

            if (dgvSongs.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a song to delete.");
                return;
            }


            //If we can get the current file continue else do not continue
            if (getCurrentSongFilePath(out filePath))

                foreach (Global.Song song in currentPlaylist.GetSongs())
                {
                    //Loop thourg the users songs
                    //If given song == a songs file path give back that object
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.pause();
        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}