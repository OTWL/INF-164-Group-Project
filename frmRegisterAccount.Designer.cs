namespace GroupProject
{
    partial class frmRegisterAccount
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnToLogin = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.lblProfilePicture = new System.Windows.Forms.Label();
            this.picProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(142, 146);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(142, 89);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 169);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(140, 106);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(136, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // btnToLogin
            // 
            this.btnToLogin.Location = new System.Drawing.Point(141, 377);
            this.btnToLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnToLogin.Name = "btnToLogin";
            this.btnToLogin.Size = new System.Drawing.Size(135, 47);
            this.btnToLogin.TabIndex = 9;
            this.btnToLogin.Text = "Back To Login";
            this.btnToLogin.UseVisualStyleBackColor = true;
            this.btnToLogin.Click += new System.EventHandler(this.btnToLogin_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(140, 315);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(135, 46);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(92, 22);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(260, 37);
            this.lblRegister.TabIndex = 7;
            this.lblRegister.Text = "Register Account";
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(219, 265);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(104, 28);
            this.btnImage.TabIndex = 14;
            this.btnImage.Text = "Choose Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lblProfilePicture
            // 
            this.lblProfilePicture.AutoSize = true;
            this.lblProfilePicture.Location = new System.Drawing.Point(110, 201);
            this.lblProfilePicture.Name = "lblProfilePicture";
            this.lblProfilePicture.Size = new System.Drawing.Size(72, 13);
            this.lblProfilePicture.TabIndex = 15;
            this.lblProfilePicture.Text = "Profile Picture";
            // 
            // picProfile
            // 
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile.Location = new System.Drawing.Point(113, 227);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(100, 66);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 16;
            this.picProfile.TabStop = false;
            // 
            // frmRegisterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 456);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.lblProfilePicture);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnToLogin);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.lblRegister);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegisterAccount";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegisterAccount_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnToLogin;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Label lblProfilePicture;
        private System.Windows.Forms.PictureBox picProfile;
    }
}