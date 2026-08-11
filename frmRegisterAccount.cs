using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class frmRegisterAccount : Form
    {
        //this stors the file path of the selected profile picture
        //remains empty when user keeps default
        private string profilePath = "";
        public frmRegisterAccount()
        {
            InitializeComponent();

            // Displays the default profile picture which is fetched from resources
            picProfile.Image = Properties.Resources.Default_Image;
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                //Gets username and password entered by user
                string Username = txtUsername.Text.Trim();
                string Password = txtPassword.Text.Trim();
                string ConfirmPassword = txtConfirmPassword.Text.Trim();

                //Checks if the username is not empty
                if (string.IsNullOrEmpty(Username))
                {
                    MessageBox.Show("Please enter a username.");
                    txtUsername.Focus();
                    return;
                }

                //Checks if password is not empty
                if (string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Please enter a password.");
                    txtPassword.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(ConfirmPassword))
                {
                    MessageBox.Show("Please confirm youre password");
                    txtConfirmPassword.Focus();
                    return;
                }

                if (ConfirmPassword != Password)
                {
                    MessageBox.Show("Passwords do not match!", "Passwords do not match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Clear();
                    return;
                }

                string value;

                if (Global.TryGetUserInfo(Username, "Users.txt", out value))
                {
                    MessageBox.Show("Username already exists. Please choose another username.");
                    txtUsername.Focus();
                    return;
                }

                //if user does not choose picture
                //use default
                if (profilePath == "")
                {
                    profilePath = "Default Image";
                }

                string userInfo = Username + "|" + Password + "|" + profilePath;
                //Append to file if not exist create it and create new line
                File.AppendAllText("Users.txt", userInfo + Environment.NewLine);

                MessageBox.Show("Successfully created an account", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GoToLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the account.\n\n" + ex.Message);
            }

        }
        private void btnToLogin_Click(object sender, EventArgs e)
        {
            GoToLogin();
        }

        private void GoToLogin()
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void frmRegisterAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            //This is to kill background forms
            Application.Exit();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    profilePath = openFileDialog.FileName;
                    picProfile.Image = Image.FromFile(profilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load profile picture.\n\n" + ex.Message);
            }
        }

        private void cbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPassword.Checked)
            {
                cbxPassword.Text = "Hide Password";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                cbxPassword.Text = "Show Password";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void cbxHidePassConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHidePassConfirm.Checked)
            {
                cbxHidePassConfirm.Text = "Hide Password";
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                cbxHidePassConfirm.Text = "Show Password";
                txtConfirmPassword.UseSystemPasswordChar = true;
            }


        }
    }
}
