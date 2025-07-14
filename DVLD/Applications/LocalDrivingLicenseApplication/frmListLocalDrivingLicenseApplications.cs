using DVLD.Applications.LocalDrivingLicenseApplication;
using DVLD.Licenses;
using DVLD.Tests;
using DVLD.Tests.TestAppointments;
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

namespace DVLD.Applications
{
    public partial class frmListLocalDrivingLicenseApplications : Form
    {
        private static DataTable _dtLocalDrivingLicensesList;

        public frmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

       
        private void frmLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtLocalDrivingLicensesList = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

            dgvLocalDrivingLicenseApplications.DataSource = _dtLocalDrivingLicensesList;

            cbFilter.SelectedIndex = 0;

            cbStatus.SelectedIndex = 0;

            if (dgvLocalDrivingLicenseApplications.Rows.Count > 0)
            {
                dgvLocalDrivingLicenseApplications.Columns[0].HeaderText = "L.D.L.AppID";
                dgvLocalDrivingLicenseApplications.Columns[0].Width = 75;

                dgvLocalDrivingLicenseApplications.Columns[1].HeaderText = "Driving Class";
                dgvLocalDrivingLicenseApplications.Columns[1].Width = 175;

                dgvLocalDrivingLicenseApplications.Columns[2].HeaderText = "National Number";
                dgvLocalDrivingLicenseApplications.Columns[2].Width = 100;

                dgvLocalDrivingLicenseApplications.Columns[3].HeaderText = "Full Name";
                dgvLocalDrivingLicenseApplications.Columns[3].Width = 175;

                dgvLocalDrivingLicenseApplications.Columns[4].HeaderText = "Application Date";
                dgvLocalDrivingLicenseApplications.Columns[4].Width = 120;
                dgvLocalDrivingLicenseApplications.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm tt";

                dgvLocalDrivingLicenseApplications.Columns[5].HeaderText = "Passed Test";
                dgvLocalDrivingLicenseApplications.Columns[5].Width = 75;

                dgvLocalDrivingLicenseApplications.Columns[6].HeaderText = "Status";
                dgvLocalDrivingLicenseApplications.Columns[6].Width = 75;

            }

            lbRecordsValue.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }



        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Visible = (cbFilter.SelectedIndex != 0 && cbFilter.SelectedIndex != 4);
            cbStatus.Visible = (cbFilter.SelectedIndex == 4);

            if (cbFilter.SelectedIndex == 0)
            {
                _dtLocalDrivingLicensesList.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
            }

            if (tbFilterValue.Visible)
            {
                tbFilterValue.Text = "";
                tbFilterValue.Focus();
            }
        }
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedIndex == 0)
                _dtLocalDrivingLicensesList.DefaultView.RowFilter = "";
            else if (cbStatus.SelectedIndex == 1)
                _dtLocalDrivingLicensesList.DefaultView.RowFilter = "Status = 'New'";
            else if (cbStatus.SelectedIndex == 2)
                _dtLocalDrivingLicensesList.DefaultView.RowFilter = "Status = 'Canceled'";
            else
                _dtLocalDrivingLicensesList.DefaultView.RowFilter = "Status = 'Completed'";

            lbRecordsValue.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
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
                    Filter = "L.D.L.AppID";
                    break;
                case 2:
                    Filter = "NationalNumber";
                    break;
                case 3:
                    Filter = "FullName";
                    break;
                default:
                    break;
            }
            
            if(tbFilterValue.Text.Trim() == "" || Filter == "None")
            {
                _dtLocalDrivingLicensesList.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
                return;
            }

            if (Filter == "L.D.L.AppID")
                _dtLocalDrivingLicensesList.DefaultView.RowFilter = string.Format("[{0}] = {1}","LocalDrivingLicenseApplicationID" ,tbFilterValue.Text.Trim());
            else 
                _dtLocalDrivingLicensesList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'",Filter, tbFilterValue.Text.Trim());

            lbRecordsValue.Text = dgvLocalDrivingLicenseApplications.Rows.Count.ToString();
        }
        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilter.SelectedIndex == 1)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }


        
        private void btAddNewLocalApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplications frm = new frmAddUpdateLocalDrivingLicenseApplications();
            frm.ShowDialog();
            frmLocalDrivingLicenseApplications_Load(null,null);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByID(LocalDrivingLicenseApplicationID);

            string Status = (string)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[6].Value;
            int PassedTests = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[5].Value;
            bool LicenseExists = LocalDrivingLicenseApplication.IsLicenseIssued();


            tsmEditApplication.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            tsmDeleteApplication.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            tsmCancelApplication.Enabled = (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            tsmScehduleTests.Enabled = !LicenseExists && (LocalDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            scheduleVisionTestToolStripMenuItem.Enabled = (PassedTests == 0);
            scheduleWrittenTestToolStripMenuItem.Enabled = (PassedTests == 1);
            scheduleStreetTestToolStripMenuItem.Enabled = (PassedTests == 2);

            tsmIssueDrivingLicense.Enabled = (PassedTests == 3 && !LicenseExists);

            tsmShowLicense.Enabled = LicenseExists;

        }

        private void tsmShowApplicationDetails_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationsInfo frm = new frmLocalDrivingLicenseApplicationsInfo((int)dgvLocalDrivingLicenseApplications
                .CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void tsmEditApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplications frm = new frmAddUpdateLocalDrivingLicenseApplications((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmLocalDrivingLicenseApplications_Load(null, null);
        }
        private void tsmDeleteApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this application ? ", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByID(
                   (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

                if (localDrivingLicenseApplication == null)
                    return;

                if (localDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Deleted Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    frmLocalDrivingLicenseApplications_Load(null, null);

                    return;
                }
                else
                    MessageBox.Show("Deleted Failed", "Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        private void tsmCancelApplication_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this application ? ","Question",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByID(
                    (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

                if (localDrivingLicenseApplication == null)
                    return;

                if (localDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Canceled Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    frmLocalDrivingLicenseApplications_Load(null, null);

                    return;
                }
                else
                    MessageBox.Show("Canceled Failed", "Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
        private void tsmIssueDrivingLicense_Click(object sender, EventArgs e)
        {
            frmIssueDrivingLicenseForTheFirstTime frm = new frmIssueDrivingLicenseForTheFirstTime((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmLocalDrivingLicenseApplications_Load(null, null);
        }
        private void tsmShowLicense_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDrivingLicenseApplication.FindByID(LocalDrivingLicenseApplicationID).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmDriverLicenseInfo frm = new frmDriverLicenseInfo(LicenseID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void tsmShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clsLocalDrivingLicenseApplication L = clsLocalDrivingLicenseApplication.FindByID((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(L.ApplicantPersonID);
            frm.ShowDialog();
        }


        private void _ScheduleTest(clsTestType.enTestType TestTypeID)
        {
            frmTestAppointments frm = new frmTestAppointments((int)dgvLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value,TestTypeID);
            frm.ShowDialog();

            frmLocalDrivingLicenseApplications_Load(null, null);
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.VisionTest);
        }
        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.WrittenTest);
        }
        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ScheduleTest(clsTestType.enTestType.StreetTest);
        }
    }
    
}
