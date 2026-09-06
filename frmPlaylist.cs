using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
        //Create the playlist in a global scope
        Global.Playlist currentPlaylist;

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

        private void frmPlaylist_Load(object sender, EventArgs e)
        {
            //Collect all the user playlists
            List<Global.Playlist> userPlaylists = Global.CurrentUser.mUserPlaylist;

            dgvSongs.DataSource = userPlaylists;
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


            //Call function from global
            if (Global.TrySaveCoverImage(playlistId, currentPlaylist.getCoverPath()))
            {
                MessageBox.Show("Playlist Cover Saved", "The album cover has been saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
    }
}
