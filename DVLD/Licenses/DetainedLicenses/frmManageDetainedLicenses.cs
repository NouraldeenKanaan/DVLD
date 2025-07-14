using DVLD.Applications.LocalDrivingLicenseApplication;
using DVLD.People;
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

namespace DVLD.Licenses.DetainedLicenses
{
    public partial class frmManageDetainedLicenses : Form
    {
        private DataTable _dtDetainedLicenses;
        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            _dtDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = _dtDetainedLicenses;

            cbFilterBy.SelectedIndex = 0;

            if (dgvDetainedLicenses.Rows.Count > 0)
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns[0].Width = 100;

                dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns[1].Width = 100;

                dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns[2].Width = 125;
                dgvDetainedLicenses.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm tt";

                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[3].Width = 75;

                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 100;

                dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns[5].Width = 125;
                dgvDetainedLicenses.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm tt";

                dgvDetainedLicenses.Columns[6].HeaderText = "N.No";
                dgvDetainedLicenses.Columns[6].Width = 75;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 300;

                dgvDetainedLicenses.Columns[8].HeaderText = "Release App ID";
                dgvDetainedLicenses.Columns[8].Width = 110;
            }

            lbRecordsValue.Text = dgvDetainedLicenses.Rows.Count.ToString();

        }



        private void btDetain_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }
        private void btRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplications frm = new frmReleaseDetainedLicenseApplications();
            frm.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }



        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Visible = (cbFilterBy.SelectedIndex != 0);

            if (cbFilterBy.SelectedIndex == 0)
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dgvDetainedLicenses.Rows.Count.ToString();
            }

            if (tbFilterValue.Visible)
            {
                tbFilterValue.Text = "";
                tbFilterValue.Focus();
            }
        }
        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 1:
                    FilterColumn = "DetainID";
                    break;
                case 2:
                    FilterColumn = "NationalNumber";
                    break;
                case 3:
                    FilterColumn = "FullName";
                    break;
                case 4:
                    FilterColumn = "ReleaseApplicationID";
                    break;
            }

            if (tbFilterValue.Text.Trim() == "" || cbFilterBy.SelectedIndex == 0)
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dgvDetainedLicenses.Rows.Count.ToString();
                return;
            }

            if (cbFilterBy.SelectedIndex == 1 || cbFilterBy.SelectedIndex == 4)
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilterValue.Text.Trim());
            else
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterValue.Text.Trim());

            lbRecordsValue.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }
        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 1 || cbFilterBy.SelectedIndex == 4)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void tsmShowPersonDetails_Click(object sender, EventArgs e)
        {
            clsLicense LicenseInfo = clsLicense.FindByID((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);

            frmShowPersonDetails frm = new frmShowPersonDetails(LicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void tsmShowLicenseDetails_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }
        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clsLicense LicenseInfo = clsLicense.FindByID((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);

            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(LicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void tsmReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplications frm = new frmReleaseDetainedLicenseApplications((int)dgvDetainedLicenses.CurrentRow
                .Cells[0].Value);
            frm.ShowDialog();
            frmManageDetainedLicenses_Load(null, null);
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            tsmReleaseDetainedLicense.Enabled = ((bool)dgvDetainedLicenses.CurrentRow.Cells[3].Value == false);
        }
    }
}
