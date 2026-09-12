using System.Windows.Forms;

namespace GroupProject
{
    public partial class frmSongInfo : Form
    {
        public string SongName = "";
        public string SongArtist = "";
        public string SongAlbum = "";
        public string SongGenre = "";


        public frmSongInfo()
        {
            InitializeComponent();
        }

        public bool SavedSuccessfully = false;

        private void btnSaveInfo_Click(object sender, System.EventArgs e)
        {

            //Check that all required fields have been entered
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtArtist.Text) ||
                string.IsNullOrWhiteSpace(txtAlbum.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                MessageBox.Show("Please fill in all song information.");
                return;
            }

            SongName = txtTitle.Text.Trim();
            SongArtist = txtArtist.Text.Trim();
            SongAlbum = txtAlbum.Text.Trim();
            SongGenre = txtGenre.Text.Trim();

            SavedSuccessfully = true;

            MessageBox.Show("Song created succesfully");

            //Clear data to keep the form clean
            txtTitle.Clear();
            txtArtist.Clear();
            txtAlbum.Clear();
            txtGenre.Clear();

            this.Close();
        }
    }

}
