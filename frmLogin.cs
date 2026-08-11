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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Call try get user
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text.Trim();



            if (Username.Length <= 0)
            {
                MessageBox.Show("Please Enter a Username");
                txtUsername.Focus();
                return;
            }

            //If password is invalid
            if (Password.Length <= 0)
            {
                MessageBox.Show("Please Enter a Password");
                txtPassword.Focus();
                return;
            }

            string value;

            //Get rid of magic numbers
            const int UserPassword = 0;
            const int UserFilePath = 1;

            //User Found
            if (Global.TryGetUserInfo(Username, "Users.txt", out value))
            {
                //We get this from the function Password|FilePath
                string[] valueArray = value.Split('|');

                if (valueArray[UserPassword] == Password)
                {
                    // Create the user object
                    Global.CurrentUser = new User(Username, valueArray[UserFilePath]);
                    //Go to next form
                    frmHome frmHome = new frmHome();
                    this.Hide();
                    frmHome.Show();

                }
                else
                {
                    MessageBox.Show("Username or password is incorect");
                    return;
                }
            }
            //If no user found
            else
            {
                MessageBox.Show("Username or password is incorect");
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
