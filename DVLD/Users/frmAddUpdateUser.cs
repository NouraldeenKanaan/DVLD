using DVLD_Business;
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
    public partial class frmAddUpdateUser : Form
    {
        public enum enMode { AddNew = 0 , Update = 1};
        private enMode _Mode = enMode.AddNew;

        private int _UserID = -1;
        private clsUser _User;


        public frmAddUpdateUser()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }
        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;
        }


        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lbTitle.Text = "Add New User";

                _User = new clsUser();
            }
            else
            {
                lbTitle.Text = "Update User";
                btSave.Enabled = true;
            }
        }
        private void _LoadData()
        {
            _User = clsUser.FindByUserID(_UserID);

            if (_User == null)
            {
                MessageBox.Show($"User with UserID {_UserID} not found", "Error");
                return;
            }

            ctrlPersonCardInfoWithFilter1.LoadPersonInfo(_User.PersonID);
            ctrlPersonCardInfoWithFilter1.FilterEnabled = false;

            lbUserIDValue.Text = _UserID.ToString();
            tbUsername.Text = _User.Username;
            tbPassword.Text = _User.Password;
            tbConfirmPassword.Text = _User.Password;
            ckbIsActive.Checked = _User.IsActive;
        }
        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                tabcontrol1.SelectedTab = tabcontrol1.TabPages["tpLoginInfo"];
                return;
            }

            if (ctrlPersonCardInfoWithFilter1.PersonID != -1)
            {
                if (clsUser.IsUserExistForPersonID(ctrlPersonCardInfoWithFilter1.PersonID))
                {
                    MessageBox.Show("Selected person already has a user,Please add another one", "Select another person", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    btSave.Enabled = true;
                    tabcontrol1.SelectedTab = tabcontrol1.TabPages["tpLoginInfo"];
                }
            }
            else
            {
                MessageBox.Show("Add a person","Required", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            btSave.Enabled = true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = ctrlPersonCardInfoWithFilter1.PersonID;
            _User.Username = tbUsername.Text.Trim();
            _User.Password = tbPassword.Text.Trim();

            if (ckbIsActive.Checked)
                _User.IsActive = true;
            else
                _User.IsActive = false;

            if (_User.Save())
            {
                _UserID = _User.UserID;
                lbUserIDValue.Text = _UserID.ToString();

                lbTitle.Text = "Update User";

                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;
                ctrlPersonCardInfoWithFilter1.FilterEnabled = false;

                return;
            }
            else
                MessageBox.Show("Data Not Saved", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(tbConfirmPassword.Text != tbPassword.Text || string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Write the right password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbConfirmPassword, null);
            }
        }
        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, "This field is required");
                return;
            }

            if(clsUser.IsUserExist(tbUsername.Text) && _User.Username != tbUsername.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "This username is exist , try another one");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbUsername, null);
            }

        }
        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "This field is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPassword, null);
            }
        }
    }
}
