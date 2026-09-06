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
            this.btnAddSong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Book Antiqua", 29.25F);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(113, 7);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(264, 46);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Playlist Name";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.lblDateCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.lblDateCreated.Location = new System.Drawing.Point(172, 53);
            this.lblDateCreated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(102, 20);
            this.lblDateCreated.TabIndex = 1;
            this.lblDateCreated.Text = "Date Created";
            // 
            // picCoverArt
            // 
            this.picCoverArt.Location = new System.Drawing.Point(9, 76);
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
            this.btnSelectCoverImage.Location = new System.Drawing.Point(9, 316);
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
            this.BtnSaveCover.Location = new System.Drawing.Point(119, 316);
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
            this.btnBack.Location = new System.Drawing.Point(835, 316);
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
            this.ColGenre});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSongs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSongs.Location = new System.Drawing.Point(296, 76);
            this.dgvSongs.Name = "dgvSongs";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvSongs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSongs.Size = new System.Drawing.Size(443, 212);
            this.dgvSongs.TabIndex = 6;
            // 
            // ColTitle
            // 
            this.ColTitle.HeaderText = "Title";
            this.ColTitle.Name = "ColTitle";
            // 
            // colArtist
            // 
            this.colArtist.HeaderText = "Artist";
            this.colArtist.Name = "colArtist";
            // 
            // ColAlbum
            // 
            this.ColAlbum.HeaderText = "Album";
            this.ColAlbum.Name = "ColAlbum";
            // 
            // ColGenre
            // 
            this.ColGenre.HeaderText = "Genre";
            this.ColGenre.Name = "ColGenre";
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnAddSong.Location = new System.Drawing.Point(489, 317);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 39);
            this.btnAddSong.TabIndex = 7;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(932, 393);
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
            this.Load += new System.EventHandler(this.frmPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCoverArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGenre;
        private System.Windows.Forms.Button btnAddSong;
    }
}