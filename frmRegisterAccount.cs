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

                //Checks if the username is not empty
                if (Username.Length <= 0)
                {
                    MessageBox.Show("Please enter a username.");
                    txtUsername.Focus();
                    return;
                }

                //Checks if password is not empty
                if (Password.Length <= 0)
                {
                    MessageBox.Show("Please enter a password.");
                    txtPassword.Focus();
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

                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the account.\n\n" + ex.Message);
            }

        }
        private void btnToLogin_Click(object sender, EventArgs e)
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
    }
}
