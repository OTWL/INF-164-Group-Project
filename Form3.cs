using System;
using System.Windows.Forms;
using System.Drawing;

namespace GroupProject
{
    public partial class frmPlaylist : Form

    {
        private string activePlaylistName;


        public frmPlaylist()
        {
            InitializeComponent();
            LoadSelectedPlaylist();
        }

        private void LoadSelectedPlaylist()
        {
            try
            {
                //call user object to get id
                //ID is the tilte of the playlist
                string playlistId = Global.CurrentUser.GetSelectedPlaylistId();

                //We can check if it is null as we return null if none found
                if (!string.IsNullOrEmpty(playlistId))
                {
                    //calling method to get playlist id 
                    var currentPlaylist = Global.CurrentUser.GetPlaylistID(playlistId);

                    //Set the labels of the name and the date of creation to the values from the playlist id
                    lblName.Text = currentPlaylist.GetTitle();
                    lblDateCreated.Text = currentPlaylist.GetDateOfCreation();

                    if (currentPlaylist != null)
                    {
                        //Set's the current form name to name of the playlist
                        this.Text = "Playlist - " + currentPlaylist.GetTitle();

                        //Get the cover image file path from the playlist object
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

                            //No need for an else statement as we know that the image path is valid
                            //so we can load it straight into the pictureBox
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
            
        }
    }
}
