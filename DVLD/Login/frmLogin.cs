using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;


namespace DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string Username = "", Password = "";

            if (clsGlobal.LoadCredential(ref Username, ref Password))
            {
                tbUsername.Text = Username;
                tbPassword.Text = Password;
                cbRememberMe.Checked = true;
            }
            else
                cbRememberMe.Checked = false;
            
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
                tbPassword.UseSystemPasswordChar = false;
            else
                tbPassword.UseSystemPasswordChar = true;
        }

        private void btSignIn_Click(object sender, EventArgs e)
        {
            clsUser User = clsUser.FindByUsernameAndPassword(tbUsername.Text.Trim(), tbPassword.Text.Trim());

            if(User != null)
            {

                if (cbRememberMe.Checked)
                    clsGlobal.RememberUsernameAndPassword(tbUsername.Text.Trim(), tbPassword.Text.Trim());
                else
                    clsGlobal.RememberUsernameAndPassword(string.Empty, string.Empty);

                if(!User.IsActive)
                {
                    tbUsername.Focus();
                    MessageBox.Show("Your account isn't active,Contact Admin", "Not Active",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else
                {
                    clsGlobal.CurrentUser = User;
                    this.Hide();
                    frmMain Main = new frmMain(this);
                    Main.ShowDialog();
                }

            }
            else
            {
                tbUsername.Focus();
                MessageBox.Show("Invalid Username/Password", "Wrong Credential", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
