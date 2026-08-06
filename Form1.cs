using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            }

            //If password is invalid
            if (Password.Length <= 0)
            {
                MessageBox.Show("Please Enter a Password");
                txtPassword.Focus();
            }

            string value;
            //User Found
            if (Global.TryGetUser(Username, out value))
            {
                //We get the password of the username we entered

                if (value == Password)
                {
                    //Go to next form
                    MessageBox.Show("Welcome user");
                    // Create the user

                    Global.CurrentUser = new User(Username);




                }
                else
                {
                    MessageBox.Show("Usernane or password is incorect");

                }
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
    }
}
