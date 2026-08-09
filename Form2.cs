using System;
using System.Collections.Generic;
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
        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoToPlaylist_Click(object sender, EventArgs e)
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

            //Check if this does not close everything
            Application.Exit();
        }

        private void LoadUserPlaylists()
        {
            //Forgot to push this to main
            List<Global.Playlist> PlayLists = Global.CurrentUser.GetPlaylists();

            foreach (Global.Playlist p in PlayLists)
            {
                lstPlaylists.Items.Add(p.GetTitle() + " - Created: " + p.GetDateOfCreation());
            }
        }
    }
}
