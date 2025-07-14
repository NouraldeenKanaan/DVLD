using DVLD.Licenses;
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

namespace DVLD.Applications.ApplicationControls
{
    public partial class ctrlLocalDrivingApplicationInfoCard : UserControl
    {
        private int _L_D_L_AppID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        private int _LicenseID = -1;
        private clsLicense _LicenseInfo;

        public int LocalDrivingLicenseApplicationID { get { return _L_D_L_AppID; } }
        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication { get { return _LocalDrivingLicenseApplication; } }

        public ctrlLocalDrivingApplicationInfoCard()
        {
            InitializeComponent();
        }


        public void LoadApplicationInfoByLocalDrivingAppID(int LocalDrivingLicenseApplicationID)
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByID(LocalDrivingLicenseApplicationID);

            if(_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show($"No application With ID {_L_D_L_AppID.ToString()} to show it", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _L_D_L_AppID = LocalDrivingLicenseApplicationID;

            lbD_L_AppIDValue.Text = _L_D_L_AppID.ToString();
            lbLicenseClassValue.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lbPassedTestsValue.Text = _LocalDrivingLicenseApplication.TotalPassedTest().ToString() + "/3";

            ucApplicationBasicInfoCard1.LoadBasicApplicationInfo(_LocalDrivingLicenseApplication.ApplicationID);

            _LicenseID = _LocalDrivingLicenseApplication.GetActiveLicenseID();

            linkLabelShowLicenseInfo.Enabled = (_LicenseID != -1);
        }


        private void linkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }
    }
}
