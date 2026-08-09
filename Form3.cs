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
            activePlaylistName = playlistName;
            LoadPlaylistView();
        }

        private void LoadPlaylistView()
        {
            this.Text = "Playlist:" + activePlaylistName;
        }
    }
}
