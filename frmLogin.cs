using System;
using System.Windows.Forms;
using static GroupProject.Global;

namespace GroupProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            TryGetUserInfo("", "User", out _);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Call try get user
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();



            if (Username.Length <= 0)
            {
                MessageBox.Show("Please Enter a Username");
                //Set focus to Username textbox
                txtUsername.Focus();
                return;
            }

            //If password is invalid
            if (Password.Length <= 0)
            {
                MessageBox.Show("Please Enter a Password");
                //Set focus to Password textbox
                txtPassword.Focus();
                return;
            }

            //Create User var
            User value;

            //User Found
            if (Global.TryGetUserInfo(Username, "User", out value))
            {
                //We get this from the function Password|FilePath
                if (value.Password == Password)
                {
                    // Create the user object
                    Global.CurrentUser = new User(Username, value.ProfilePath, Password);
                    //Go to next form
                    frmHome frmHome = new frmHome();
                    this.Hide();
                    frmHome.Show();

                }
                else
                {
                    MessageBox.Show("Username or password is incorrect");
                    return;
                }
            }
            //If no user found
            else
            {
                MessageBox.Show("Username or password is incorrect");
                return;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //Create account form and then go to is
            frmRegisterAccount createAccountForm = new frmRegisterAccount();
            this.Hide();
            createAccountForm.ShowDialog();

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbxPassword_CheckedChanged(object sender, EventArgs e)
        {

            //Show password
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
    }
}
