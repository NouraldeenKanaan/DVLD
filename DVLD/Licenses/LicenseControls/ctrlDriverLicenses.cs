using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Licenses.LicenseControls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID = -1;
        private clsDriver _DriverInfo;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        public void LoadDriverLicensesInfo(int PersonID)
        {
            _DriverInfo = clsDriver.FindByPersonID(PersonID);

            if(_DriverInfo == null)
            {
                MessageBox.Show("No data to show it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverID = _DriverInfo.DriverID;

            _GetLocalLicenses();
            _GetInternationalLicense();

        }

        private void _GetInternationalLicense()
        {
            DataTable dtInternationalLicense = clsInternationalLicense.GetInternationalLicenseByDriverID(_DriverID);

            dgvInternationalLicenses.DataSource = dtInternationalLicense;

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int License ID";
                dgvInternationalLicenses.Columns[0].Width = 100;

                dgvInternationalLicenses.Columns[1].HeaderText = "App ID";
                dgvInternationalLicenses.Columns[1].Width = 100;
                
                dgvInternationalLicenses.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[2].Width = 225;
                
                dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[3].Width = 200;
                dgvInternationalLicenses.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                
                dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[4].Width = 200;
                dgvInternationalLicenses.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                
                dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[5].Width = 80;

            }

            lbInternationalRecordsValue.Text = dgvInternationalLicenses.Rows.Count.ToString();

        }
        private void _GetLocalLicenses()
        {
            DataTable LocalLicenses = _DriverInfo.GetDriverLicenses();

            dgvLocalLicenses.DataSource = LocalLicenses;

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "Lic ID";
                dgvLocalLicenses.Columns[0].Width = 100;

                dgvLocalLicenses.Columns[1].HeaderText = "App ID";
                dgvLocalLicenses.Columns[1].Width = 100;

                dgvLocalLicenses.Columns[2].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[2].Width = 225;

                dgvLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[3].Width = 200;
                dgvLocalLicenses.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[4].Width = 200;
                dgvLocalLicenses.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvLocalLicenses.Columns[5].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[5].Width = 80;

            }

            lbLocalRecordsValue.Text = dgvLocalLicenses.Rows.Count.ToString();

        }


        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo((int)dgvLocalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showInternationalLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverInternationalLicenseInfo frm = new frmDriverInternationalLicenseInfo((int)dgvInternationalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
