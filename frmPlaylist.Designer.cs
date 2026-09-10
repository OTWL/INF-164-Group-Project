namespace GroupProject
{
    partial class frmPlaylist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaylist));
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.picCoverArt = new System.Windows.Forms.PictureBox();
            this.btnSelectCoverImage = new System.Windows.Forms.Button();
            this.BtnSaveCover = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.ColTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lblNumTracks = new System.Windows.Forms.Label();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.btnPlaySong = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Book Antiqua", 29.25F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(309, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(264, 46);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Playlist Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lblDateCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.lblDateCreated.Location = new System.Drawing.Point(386, 55);
            this.lblDateCreated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(102, 20);
            this.lblDateCreated.TabIndex = 1;
            this.lblDateCreated.Text = "Date Created";
            // 
            // picCoverArt
            // 
            this.picCoverArt.Location = new System.Drawing.Point(12, 99);
            this.picCoverArt.Name = "picCoverArt";
            this.picCoverArt.Size = new System.Drawing.Size(208, 172);
            this.picCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoverArt.TabIndex = 2;
            this.picCoverArt.TabStop = false;
            // 
            // btnSelectCoverImage
            // 
            this.btnSelectCoverImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnSelectCoverImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCoverImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectCoverImage.Location = new System.Drawing.Point(11, 276);
            this.btnSelectCoverImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectCoverImage.Name = "btnSelectCoverImage";
            this.btnSelectCoverImage.Size = new System.Drawing.Size(84, 40);
            this.btnSelectCoverImage.TabIndex = 3;
            this.btnSelectCoverImage.Text = "Select Cover Image";
            this.btnSelectCoverImage.UseVisualStyleBackColor = false;
            this.btnSelectCoverImage.Click += new System.EventHandler(this.btnSelectCoverImage_Click);
            // 
            // BtnSaveCover
            // 
            this.BtnSaveCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.BtnSaveCover.Enabled = false;
            this.BtnSaveCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveCover.ForeColor = System.Drawing.Color.White;
            this.BtnSaveCover.Location = new System.Drawing.Point(134, 276);
            this.BtnSaveCover.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaveCover.Name = "BtnSaveCover";
            this.BtnSaveCover.Size = new System.Drawing.Size(86, 40);
            this.BtnSaveCover.TabIndex = 4;
            this.BtnSaveCover.Text = "Save Cover Image";
            this.BtnSaveCover.UseVisualStyleBackColor = false;
            this.BtnSaveCover.Click += new System.EventHandler(this.BtnSaveCover_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(978, 342);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvSongs
            // 
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTitle,
            this.colArtist,
            this.ColAlbum,
            this.ColGenre,
            this.colFilePath});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSongs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSongs.Location = new System.Drawing.Point(293, 99);
            this.dgvSongs.MultiSelect = false;
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvSongs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSongs.Size = new System.Drawing.Size(443, 212);
            this.dgvSongs.TabIndex = 6;
            // 
            // ColTitle
            // 
            this.ColTitle.HeaderText = "Title";
            this.ColTitle.MinimumWidth = 6;
            this.ColTitle.Name = "ColTitle";
            this.ColTitle.ReadOnly = true;
            this.ColTitle.Width = 125;
            // 
            // colArtist
            // 
            this.colArtist.HeaderText = "Artist";
            this.colArtist.MinimumWidth = 6;
            this.colArtist.Name = "colArtist";
            this.colArtist.ReadOnly = true;
            this.colArtist.Width = 125;
            // 
            // ColAlbum
            // 
            this.ColAlbum.HeaderText = "Album";
            this.ColAlbum.MinimumWidth = 6;
            this.ColAlbum.Name = "ColAlbum";
            this.ColAlbum.ReadOnly = true;
            this.ColAlbum.Width = 125;
            // 
            // ColGenre
            // 
            this.ColGenre.HeaderText = "Genre";
            this.ColGenre.MinimumWidth = 6;
            this.ColGenre.Name = "ColGenre";
            this.ColGenre.ReadOnly = true;
            this.ColGenre.Width = 125;
            // 
            // colFilePath
            // 
            this.colFilePath.HeaderText = "File Path";
            this.colFilePath.MinimumWidth = 6;
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.ReadOnly = true;
            this.colFilePath.Visible = false;
            this.colFilePath.Width = 125;
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnAddSong.Location = new System.Drawing.Point(293, 321);
            this.btnAddSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 36);
            this.btnAddSong.TabIndex = 7;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // lblNumTracks
            // 
            this.lblNumTracks.AutoSize = true;
            this.lblNumTracks.ForeColor = System.Drawing.Color.Black;
            this.lblNumTracks.Location = new System.Drawing.Point(638, 314);
            this.lblNumTracks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTracks.Name = "lblNumTracks";
            this.lblNumTracks.Size = new System.Drawing.Size(98, 13);
            this.lblNumTracks.TabIndex = 8;
            this.lblNumTracks.Text = "Number of Tracks: ";
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnDeleteSong.Location = new System.Drawing.Point(456, 321);
            this.btnDeleteSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteSong.TabIndex = 9;
            this.btnDeleteSong.Text = "Delete Song";
            this.btnDeleteSong.UseVisualStyleBackColor = false;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnPlaySong.Location = new System.Drawing.Point(373, 321);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.Size = new System.Drawing.Size(75, 36);
            this.btnPlaySong.TabIndex = 11;
            this.btnPlaySong.Text = "Play Song";
            this.btnPlaySong.UseVisualStyleBackColor = false;
            this.btnPlaySong.Click += new System.EventHandler(this.btnPlaySong_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnStop.Location = new System.Drawing.Point(546, 318);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 39);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop Song";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(778, 99);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(277, 212);
            this.mediaPlayer.TabIndex = 10;
            this.mediaPlayer.Enter += new System.EventHandler(this.mediaPlayer_Enter);
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1075, 393);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlaySong);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.lblNumTracks);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnSaveCover);
            this.Controls.Add(this.btnSelectCoverImage);
            this.Controls.Add(this.picCoverArt);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmPlaylist";
            this.Opacity = 0.99D;
            this.Text = "View Playlist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPlaylist_FormClosed);
            this.Load += new System.EventHandler(this.frmPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCoverArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.PictureBox picCoverArt;
        private System.Windows.Forms.Button btnSelectCoverImage;
        private System.Windows.Forms.Button BtnSaveCover;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Label lblNumTracks;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilePath;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button btnPlaySong;
        private System.Windows.Forms.Button btnStop;
    }
}