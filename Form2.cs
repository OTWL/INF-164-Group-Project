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

            try
            {
                //control name for listbox should be lstPlaylists

                if(lstPlaylists.SelectedItem !=null)
                {
                    string selectedLine= lstPlaylists.SelectedItem.ToString();
                    string[] playlistDetails= selectedLine.Split('|');
                    

                   if(playlistDetails.Length > 0 )
                    {
                        string playlistId= playlistDetails[0].Trim();

                        //setter 
                        Global.CurrentUser.setSelectedPlaylistId(playlistId);

                        //open playlist form
                        frmPlaylist playlistForm= new frmPlaylist();

                        this.Hide();
                        playlistForm.ShowDialog();
                        this.Show();
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Please select a playlist to open." , "Selection required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //Check if this does not close everything
            Application.Exit();
        }

        private void LoadUserPlaylists()
        {
            try
            {
                lstPlaylists.Items.Clear();

                //check if file exists then read line by line 
                string filePath = "playlists.txt";
                if(System.IO.File.Exists(filePath))
                {
                    using(System.IO.StreamReader reader  = new System.IO.StreamReader(filePath))
                    {
                        string line;
                        while((line = reader.ReadLine()) != null)
                        {
                            if(line.Contains("|"))
                            {
                                lstPlaylists.Items.Add(line);
                            }
                        }
                    }
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show("Error loading playlists:" + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
