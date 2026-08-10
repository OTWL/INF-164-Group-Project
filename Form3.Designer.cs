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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.picCoverArt = new System.Windows.Forms.PictureBox();
            this.btnSelectCoverImage = new System.Windows.Forms.Button();
            this.BtnSaveCover = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCoverArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Playlist Name";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(28, 60);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(87, 16);
            this.lblDateCreated.TabIndex = 1;
            this.lblDateCreated.Text = "Date Created";
            // 
            // picCoverArt
            // 
            this.picCoverArt.Location = new System.Drawing.Point(32, 94);
            this.picCoverArt.Margin = new System.Windows.Forms.Padding(4);
            this.picCoverArt.Name = "picCoverArt";
            this.picCoverArt.Size = new System.Drawing.Size(403, 260);
            this.picCoverArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoverArt.TabIndex = 2;
            this.picCoverArt.TabStop = false;
            // 
            // btnSelectCoverImage
            // 
            this.btnSelectCoverImage.Location = new System.Drawing.Point(32, 389);
            this.btnSelectCoverImage.Name = "btnSelectCoverImage";
            this.btnSelectCoverImage.Size = new System.Drawing.Size(112, 49);
            this.btnSelectCoverImage.TabIndex = 3;
            this.btnSelectCoverImage.Text = "Select Cover Image";
            this.btnSelectCoverImage.UseVisualStyleBackColor = true;
            this.btnSelectCoverImage.Click += new System.EventHandler(this.btnSelectCoverImage_Click);
            // 
            // BtnSaveCover
            // 
            this.BtnSaveCover.Enabled = false;
            this.BtnSaveCover.Location = new System.Drawing.Point(150, 389);
            this.BtnSaveCover.Name = "BtnSaveCover";
            this.BtnSaveCover.Size = new System.Drawing.Size(114, 49);
            this.BtnSaveCover.TabIndex = 4;
            this.BtnSaveCover.Text = "Save Cover Image";
            this.BtnSaveCover.UseVisualStyleBackColor = true;
            this.BtnSaveCover.Click += new System.EventHandler(this.BtnSaveCover_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(367, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 49);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BtnSaveCover);
            this.Controls.Add(this.btnSelectCoverImage);
            this.Controls.Add(this.picCoverArt);
            this.Controls.Add(this.lblDateCreated);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPlaylist";
            this.Text = "View Playlist";
            this.Load += new System.EventHandler(this.frmPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCoverArt)).EndInit();
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
    }
}