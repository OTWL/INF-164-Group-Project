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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterAccount));
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
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cbxPassword = new System.Windows.Forms.CheckBox();
            this.cbxHidePassConfirm = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(155, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(155, 94);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(153, 172);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(180, 22);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(153, 112);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 22);
            this.txtUsername.TabIndex = 10;
            // 
            // btnToLogin
            // 
            this.btnToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToLogin.ForeColor = System.Drawing.Color.White;
            this.btnToLogin.Location = new System.Drawing.Point(153, 481);
            this.btnToLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToLogin.Name = "btnToLogin";
            this.btnToLogin.Size = new System.Drawing.Size(180, 58);
            this.btnToLogin.TabIndex = 9;
            this.btnToLogin.Text = "Back To Login";
            this.btnToLogin.UseVisualStyleBackColor = false;
            this.btnToLogin.Click += new System.EventHandler(this.btnToLogin_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(153, 409);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(180, 57);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Nirmala UI", 29.25F);
            this.lblRegister.Location = new System.Drawing.Point(89, 9);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(397, 66);
            this.lblRegister.TabIndex = 7;
            this.lblRegister.Text = "Register Account";
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(272, 336);
            this.btnImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(143, 40);
            this.btnImage.TabIndex = 14;
            this.btnImage.Text = "Choose Image";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lblProfilePicture
            // 
            this.lblProfilePicture.AutoSize = true;
            this.lblProfilePicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.lblProfilePicture.Location = new System.Drawing.Point(114, 275);
            this.lblProfilePicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfilePicture.Name = "lblProfilePicture";
            this.lblProfilePicture.Size = new System.Drawing.Size(89, 16);
            this.lblProfilePicture.TabIndex = 15;
            this.lblProfilePicture.Text = "Profile Picture";
            // 
            // picProfile
            // 
            this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProfile.Location = new System.Drawing.Point(117, 295);
            this.picProfile.Margin = new System.Windows.Forms.Padding(4);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(133, 81);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfile.TabIndex = 16;
            this.picProfile.TabStop = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(155, 215);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(115, 16);
            this.lblConfirmPassword.TabIndex = 18;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(153, 233);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(180, 22);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // cbxPassword
            // 
            this.cbxPassword.AutoSize = true;
            this.cbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.cbxPassword.Location = new System.Drawing.Point(348, 174);
            this.cbxPassword.Name = "cbxPassword";
            this.cbxPassword.Size = new System.Drawing.Size(124, 20);
            this.cbxPassword.TabIndex = 19;
            this.cbxPassword.Text = "Show password";
            this.cbxPassword.UseVisualStyleBackColor = true;
            this.cbxPassword.CheckedChanged += new System.EventHandler(this.cbxPassword_CheckedChanged);
            // 
            // cbxHidePassConfirm
            // 
            this.cbxHidePassConfirm.AutoSize = true;
            this.cbxHidePassConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(153)))), ((int)(((byte)(174)))));
            this.cbxHidePassConfirm.Location = new System.Drawing.Point(348, 233);
            this.cbxHidePassConfirm.Name = "cbxHidePassConfirm";
            this.cbxHidePassConfirm.Size = new System.Drawing.Size(124, 20);
            this.cbxHidePassConfirm.TabIndex = 20;
            this.cbxHidePassConfirm.Text = "Show password";
            this.cbxHidePassConfirm.UseVisualStyleBackColor = true;
            this.cbxHidePassConfirm.CheckedChanged += new System.EventHandler(this.cbxHidePassConfirm_CheckedChanged);
            // 
            // frmRegisterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(501, 550);
            this.Controls.Add(this.cbxHidePassConfirm);
            this.Controls.Add(this.cbxPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(7)))), ((int)(((byte)(5)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmRegisterAccount";
            this.Opacity = 0.99D;
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
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.CheckBox cbxPassword;
        private System.Windows.Forms.CheckBox cbxHidePassConfirm;
    }
}