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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //WHen form is loading

            //Example code
            /*
             This code creates a List with the Playlist object so it can store playlists 
             It then goes and loops over them and shows them in a listbox
             */
            List<Global.Playlist> PlayLists = Global.CurrentUser.GetPlaylists();

            foreach (Global.Playlist p in PlayLists)
            {
                MessageBox.Show(p.GetTitle() + " - Created: " + p.GetDateOfCreation());
            }

        }

        private void btnGoToPlaylist_Click(object sender, EventArgs e)
        {
            //Go to PlayList Page
            //
            //Check if this does not close everything
            Application.Exit();
        }
    }
}
