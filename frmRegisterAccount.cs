using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            // Displays the default profile picture
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
                File.AppendAllText("Users.txt", userInfo + Environment.NewLine);

                MessageBox.Show("Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the account.\n\n" + ex.Message);
            }

            //Create account
            //button for the Register button when the UI is made, btnCreateAccount

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Please fill in both username and password fields.", "Validation Errror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dummyOutput;
            if (Global.TryGetUserInfo(username, "Users.txt", out dummyOutput))
            {
                MessageBox.Show("This username already exists. Please choose another one.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {



                //saving details to text file

                using (StreamWriter writer = new StreamWriter("users.txt", true))
                {
                    writer.WriteLine(username + "|" + password);
                }

                MessageBox.Show("Account created successfully!");

                //redirected back to the login page
                frmLogin loginForm = new frmLogin();
                this.Hide();
                loginForm.ShowDialog();

            }



            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
