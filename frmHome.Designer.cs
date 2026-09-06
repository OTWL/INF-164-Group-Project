namespace GroupProject
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnGoToPlaylist = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.picAlbum = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToPlaylist
            // 
            this.btnGoToPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnGoToPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnGoToPlaylist.Location = new System.Drawing.Point(14, 306);
            this.btnGoToPlaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoToPlaylist.Name = "btnGoToPlaylist";
            this.btnGoToPlaylist.Size = new System.Drawing.Size(80, 34);
            this.btnGoToPlaylist.TabIndex = 0;
            this.btnGoToPlaylist.Text = "Open Playlist";
            this.btnGoToPlaylist.UseVisualStyleBackColor = false;
            this.btnGoToPlaylist.Click += new System.EventHandler(this.btnGoToPlaylist_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Book Antiqua", 20F);
            this.lblWelcome.Location = new System.Drawing.Point(8, 7);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(282, 94);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome UserName";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.Location = new System.Drawing.Point(13, 132);
            this.lstPlaylists.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(251, 134);
            this.lstPlaylists.TabIndex = 2;
            this.lstPlaylists.DoubleClick += new System.EventHandler(this.lstPlaylists_DoubleClick);
            this.lstPlaylists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstPlaylists_MouseDown);
            // 
            // picProfile
            // 
            this.picProfile.Location = new System.Drawing.Point(955, 3);
            this.picProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(78, 75);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 4;
            this.picProfile.TabStop = false;
            // 
            // picAlbum
            // 
            this.picAlbum.Location = new System.Drawing.Point(786, 89);
            this.picAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAlbum.Name = "picAlbum";
            this.picAlbum.Size = new System.Drawing.Size(247, 251);
            this.picAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlbum.TabIndex = 3;
            this.picAlbum.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(184, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create Playlist";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1044, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.picAlbum);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lstPlaylists);
            this.Controls.Add(this.btnGoToPlaylist);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(5)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.Opacity = 0.99D;
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoToPlaylist;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.PictureBox picAlbum;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button button1;
    }
}