using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            /*
             Validat password
             Check if username exists (use Get info function)
             Open File dialog and save the path of the file
             Write those vaules to text file called "Users.txt"
             Should look like this: 
                Username|Password|FilePath
             */
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
