using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class frmRegisterAccount : Form
    {
        public frmRegisterAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //Create account
            //button for the Register button when the UI is made, btnCreateAccount

            string username = txtUsername.Text.Trim();
            string password= txtPassword.Text.Trim();

            if(username.Length==0 || password.Length==0)
            {
                MessageBox.Show("Please fill in both username and password fields.", "Validation Errror",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            try
            {



                //saving details to text file

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter("users.txt", true))
                {
                    writer.WriteLine(username + "," + password);
                }

                MessageBox.Show("Account created successfully!");

                //redirected back to the login page
                frmLogin loginForm = new frmLogin();
                this.Hide();
                loginForm.ShowDialog();

            }

            

        catch (Exception ex)
        {
            MessageBox.Show("An error occurred:"+ ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
    }
}
