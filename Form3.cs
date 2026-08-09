using System;
using System.Windows.Forms;

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

                    if (currentPlaylist != null)
                    {
                        //Set's the current form name to name of the playlist
                        this.Text = "Playlist - " + currentPlaylist.GetTitle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading playlist data:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
