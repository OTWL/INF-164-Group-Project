namespace GroupProject
{
    partial class frmSongInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSongInfo));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(112, 47);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(112, 23);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Title";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(112, 87);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(36, 16);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "Artist";
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(112, 111);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(132, 22);
            this.txtArtist.TabIndex = 2;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(112, 144);
            this.lblAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(45, 16);
            this.lblAlbum.TabIndex = 5;
            this.lblAlbum.Text = "Album";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(112, 167);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(132, 22);
            this.txtAlbum.TabIndex = 4;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(112, 207);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(44, 16);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(112, 230);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(132, 22);
            this.txtGenre.TabIndex = 6;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnSaveInfo.ForeColor = System.Drawing.Color.White;
            this.btnSaveInfo.Location = new System.Drawing.Point(112, 276);
            this.btnSaveInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(133, 44);
            this.btnSaveInfo.TabIndex = 9;
            this.btnSaveInfo.Text = "Save song";
            this.btnSaveInfo.UseVisualStyleBackColor = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // frmSongInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(384, 431);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTitle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(5)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmSongInfo";
            this.Opacity = 0.99D;
            this.Text = "Song Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Button btnSaveInfo;
    }
}