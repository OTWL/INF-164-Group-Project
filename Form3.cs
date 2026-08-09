using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class frmPlaylist : Form

    {
        private string activePlaylistName;

        
        public frmPlaylist(string playlistName)
        {
            InitializeComponent();
            LoadSelectedPlaylist();
        }

        private void LoadSelectedPlaylist()
        {
            try
            {
                //call user object to get id
                string playlistId = Global.CurrentUser.GetSelectedPlaylistId();

                if(!string.IsNullOrEmpty(playlistId))
                {
                    //calling method to get playlist id 
                    var currentPlaylist = Global.CurrentUser.GetPlaylistID(playlistId);

                    if(currentPlaylist!=null)
                    {
                        this.Text = "Playlist -" + currentPlaylist.GetTitle();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading playlist data:"+ ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
