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

        private void btnSaveInfo_Click(object sender, System.EventArgs e)
        {
            SongName = txtTitle.Text.Trim();
            SongArtist = txtArtist.Text.Trim();
            SongAlbum = txtAlbum.Text.Trim();
            SongGenre = txtGenre.Text.Trim();

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
