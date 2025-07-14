using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();

            this._UserID = UserID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlUserInfoCard1.LoadUserInfo(_UserID);
        }


        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCurrentPassword.Text.Trim()))
                return;

            if(tbCurrentPassword.Text != ctrlUserInfoCard1.UserInfo.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Wrong password,Enter the right password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCurrentPassword, null);
            }
        }
        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbNewPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "Enter New Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNewPassword, null);
            }
        }
        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbConfirmPassword.Text != tbNewPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Wrong Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbConfirmPassword, null);
            }
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (ctrlUserInfoCard1.UserInfo.ChangePassword(tbNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password Changed Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else
                MessageBox.Show("Changed Failed", "Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
