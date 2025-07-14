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

namespace DVLD.Licenses
{
    public partial class frmIssueDrivingLicenseForTheFirstTime : Form
    {
        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public frmIssueDrivingLicenseForTheFirstTime(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void frmIssueDrivingLicenseForTheFirstTime_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingApplicationInfoCard1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);
        }


        private void btIssue_Click(object sender, EventArgs e)
        {
            int LicenseID = ctrlLocalDrivingApplicationInfoCard1.LocalDrivingLicenseApplication
                .IssueDriverLicenseForFirstTime(tbNotesValue.Text.Trim(), clsGlobal.CurrentUser.UserID);

            if (LicenseID != -1)
            {
                MessageBox.Show($"Data saved successfully with License ID = {LicenseID}", "Successfully", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            else
                MessageBox.Show("Data saved Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
