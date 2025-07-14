using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmManageUsers : Form
    {
        private static DataTable _UsersList ;

        public frmManageUsers()
        {
            InitializeComponent();
        }


        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _UsersList = clsUser.GetAllUsers();

            dgvUsersList.DataSource = _UsersList;

            cbFilterBy.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0;

            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.Columns[0].HeaderText = "User ID";
                dgvUsersList.Columns[1].HeaderText = "Person ID";
                dgvUsersList.Columns[2].HeaderText = "Full Name";
                dgvUsersList.Columns[3].HeaderText = "UserName";
                dgvUsersList.Columns[4].HeaderText = "Is Active";

                dgvUsersList.Columns[0].Width = 140;
                dgvUsersList.Columns[1].Width = 140;
                dgvUsersList.Columns[2].Width = 250;
                dgvUsersList.Columns[3].Width = 150;
                dgvUsersList.Columns[4].Width = 101;
            }
            
            lbRecordsValue.Text = dgvUsersList.Rows.Count.ToString();
        }


        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterBy.Visible = (cbFilterBy.SelectedIndex != 0 && cbFilterBy.SelectedIndex != 5) ;
            cbIsActive.Visible = (cbFilterBy.SelectedIndex == 5);

            if (cbFilterBy.SelectedIndex == 0)
            {
                _UsersList.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dgvUsersList.Rows.Count.ToString();
            }

            if (tbFilterBy.Visible)
            {
                tbFilterBy.Text = "";
                tbFilterBy.Focus();
            }
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbIsActive.SelectedIndex)
            {
                case 0:
                    _UsersList.DefaultView.RowFilter = "";
                    break;
                case 1:
                    _UsersList.DefaultView.RowFilter = "IsActive = 1";
                    break;
                default:
                    _UsersList.DefaultView.RowFilter = "IsActive = 0";
                    break;
            }

            lbRecordsValue.Text = dgvUsersList.Rows.Count.ToString();
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 0:
                    FilterColumn = "None";
                    break;
                case 1:
                    FilterColumn = "UserID";
                    break;
                case 2:
                    FilterColumn = "PersonID";
                    break;
                case 3:
                    FilterColumn = "FullName";
                    break;
                case 4:
                    FilterColumn = "UserName";
                    break;
                default:
                    break;
            }


            if (tbFilterBy.Text.Trim() == "" || tbFilterBy.Text.Trim() == "None")
            {
                _UsersList.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dgvUsersList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID" || FilterColumn == "UserID")
                _UsersList.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilterBy.Text.Trim());
            else
                _UsersList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterBy.Text.Trim());

            lbRecordsValue.Text = dgvUsersList.Rows.Count.ToString();
        }
        private void tbFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 1 || cbFilterBy.SelectedIndex == 2)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }


        private void _AddNewUser()
        {
            frmAddUpdateUser _frmAddUpdateUser = new frmAddUpdateUser();
            _frmAddUpdateUser.ShowDialog();
            frmManageUsers_Load(null, null);
        }
        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            _AddNewUser();
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsmAddNewUser_Click(object sender, EventArgs e)
        {
            _AddNewUser();
        }
        private void tsmPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Inplemented Yet", "Soon");
        }
        private void tsmSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Inplemented Yet", "Soon");
        }
        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageUsers_Load(null, null);
        }
        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this user ? ","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                if (clsGlobal.CurrentUser.UserID == (int)dgvUsersList.CurrentRow.Cells[0].Value)
                {
                    MessageBox.Show("You can't delete your self", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (clsUser.DeleteUser((int)dgvUsersList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Deleted Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmManageUsers_Load(null, null);
                }
                else
                    MessageBox.Show("Deleted Failed", "Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
