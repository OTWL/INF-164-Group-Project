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
            string[] greetmessages = { "Welcome", "Howzit", "What's the vibe today", "Awe" };
            Random numbergenerator = new Random();
            int index = numbergenerator.Next(0, greetmessages.Length);
            lblWelcome.Text = greetmessages[index] + ", " + Global.CurrentUser.GetUsername();

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
            //Forgot to push this to main
            List<Global.Playlist> PlayLists = Global.CurrentUser.GetPlaylists();

            //Loop over list
            foreach (Global.Playlist p in PlayLists)
            {
                lstPlaylists.Items.Add(p.GetTitle() + " - Created: " + p.GetDateOfCreation());
            }
        }

        private void LoadProfilePic()
        {
            string path = Global.CurrentUser.GetProfileFilePath();

            //If path is default set to defualt image
            if (string.IsNullOrEmpty(path) || path == "Default Image")
            {
                picProfile.Image = Properties.Resources.Default_Image;
                return;
            }
            picProfile.Image = Image.FromFile(path);



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
    }
}
