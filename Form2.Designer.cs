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
            this.btnGoToPlaylist = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGoToPlaylist
            // 
            this.btnGoToPlaylist.Location = new System.Drawing.Point(98, 240);
            this.btnGoToPlaylist.Name = "btnGoToPlaylist";
            this.btnGoToPlaylist.Size = new System.Drawing.Size(106, 42);
            this.btnGoToPlaylist.TabIndex = 0;
            this.btnGoToPlaylist.Text = "Open Playlist";
            this.btnGoToPlaylist.UseVisualStyleBackColor = true;
            this.btnGoToPlaylist.Click += new System.EventHandler(this.btnGoToPlaylist_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(94, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(155, 20);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome UserName";
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.ItemHeight = 16;
            this.lstPlaylists.Location = new System.Drawing.Point(29, 81);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(296, 116);
            this.lstPlaylists.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.lstPlaylists);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnGoToPlaylist);
            this.Name = "frmHome";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToPlaylist;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox lstPlaylists;
    }
}