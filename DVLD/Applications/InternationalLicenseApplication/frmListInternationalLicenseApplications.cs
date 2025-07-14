using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DVLD_Business;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.People;
using DVLD.Licenses;

namespace DVLD.Applications.InternationalLicenseApplication
{
    public partial class frmListInternationalLicenseApplications : Form
    {
        private DataTable dtAllInternationalLicenseApplications;
        public frmListInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmListInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            dtAllInternationalLicenseApplications = clsInternationalLicense.GetInternationalLicenses();

            dgvInternationalLicenses.DataSource = dtAllInternationalLicenseApplications;

            cbFilter.SelectedIndex = 0;

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 40;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 40;

                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 40;

                dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[3].Width = 40;

                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 75;
                dgvInternationalLicenses.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm tt";

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 75;
                dgvInternationalLicenses.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm tt";

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 100;

            }

            lbRecordsValue.Text = dgvInternationalLicenses.Rows.Count.ToString();

        }


        private void btAddNewInternationalLicenselApplication_Click(object sender, EventArgs e)
        {
            frmAddInternationalLicense frm = new frmAddInternationalLicense();
            frm.ShowDialog();
            frmListInternationalLicenseApplications_Load(null, null);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Visible = (cbFilter.SelectedIndex != 0);

            if (cbFilter.SelectedIndex == 0)
            {
                dtAllInternationalLicenseApplications.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dgvInternationalLicenses.Rows.Count.ToString();
            }

            if (cbFilter.SelectedIndex != 0)
            {
                tbFilterValue.Text = "";
                tbFilterValue.Focus();
            }
        }
        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string Filter = "";

            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    Filter = "None";
                    break;
                case 1:
                    Filter = "InternationalLicenseID";
                    break;
                case 2:
                    Filter = "ApplicationID";
                    break;
                case 3:
                    Filter = "DriverID";
                    break;
                case 4:
                    Filter = "IssuedUsingLocalLicenseID";
                    break;
                default:
                    break;
            }

            if (tbFilterValue.Text.Trim() == "" || cbFilter.SelectedIndex == 0)
            {
                dtAllInternationalLicenseApplications.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dgvInternationalLicenses.Rows.Count.ToString();
                return;
            }
            else
                dtAllInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}",Filter , tbFilterValue.Text.Trim());

            lbRecordsValue.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }
        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.FindByID((int)dgvInternationalLicenses.CurrentRow
                .Cells[2].Value);

            frmShowPersonDetails frm = new frmShowPersonDetails(Driver.PersonID);
            frm.ShowDialog();
        }
        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmDriverInternationalLicenseInfo frm = new frmDriverInternationalLicenseInfo((int)dgvInternationalLicenses.CurrentRow
                .Cells[0].Value);
            frm.ShowDialog();
        }
        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.FindByID((int)dgvInternationalLicenses.CurrentRow
                  .Cells[2].Value);

            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(Driver.PersonID);
            frm.ShowDialog();
        }
    }
}
