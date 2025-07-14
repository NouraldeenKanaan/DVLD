using DVLD.Licenses;
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

namespace DVLD.Applications.LocalDrivingLicenseApplication
{
    public partial class frmReleaseDetainedLicenseApplications : Form
    {
        private int _LicenseID = -1;
        private int _DetainedID = -1;

        public frmReleaseDetainedLicenseApplications(int DetainedID = -1)
        {
            InitializeComponent();

            this._DetainedID = DetainedID;
        }

        private void frmReleaseDetainedLicenseApplications_Load(object sender, EventArgs e)
        {
            lbApplicationFeesValue.Text = Convert.ToDouble(clsApplicationType.FindByApplicationTypeID((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense)
                .ApplicationTypeFees).ToString();

            if (_DetainedID != -1)
                _LoadData();
        }

        private void _LoadData()
        {
            clsDetainedLicense DetainedLicense = clsDetainedLicense.FindByDetainID(_DetainedID);
            ctrlDriverLicenseInfoWithFilter1.LoadInfo(DetainedLicense.LicenseID);
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            if (obj == -1)
                return;

            lbLicenseIDValue.Text = obj.ToString();
            _LicenseID = obj;
            linkLabelLicensesHistory.Enabled = true;

            if (!ctrlDriverLicenseInfoWithFilter1.LicenseInfo.IsDetained)
            {
                MessageBox.Show("This License not detained,Try an detained license", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            clsDetainedLicense DetainedLicense = clsDetainedLicense.FindByLicenseID(_LicenseID);

            lbDetainIDValue.Text = DetainedLicense.DetainID.ToString();
            lbDetainDateValue.Text = DetainedLicense.DetainDate.ToString("dd/MM/yyyy");
            lbFineFeesValue.Text = Convert.ToDouble(DetainedLicense.FineFees).ToString();
            lbTotalFeesValue.Text = Convert.ToDouble(DetainedLicense.FineFees + clsApplicationType.FindByApplicationTypeID((int)clsApplication.
                enApplicationType.ReleaseDetainedDrivingLicense).ApplicationTypeFees).ToString();

            btRelease.Enabled = true;

        }

        private void btRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to release this license ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                clsDetainedLicense Release = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.Release(clsGlobal.CurrentUser.UserID);

                if (Release == null)
                    return;

                MessageBox.Show("This license released successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Release = clsDetainedLicense.FindByDetainID(Release.DetainID);

                lbCreatedByValue.Text = Release.ReleasedByUserInfo.Username;
                lbApplicationIDValue.Text = Release.ReleaseApplicationID.ToString();
                linkLabelLicensesInfo.Enabled = true;
                btRelease.Enabled = false;
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(ctrlDriverLicenseInfoWithFilter1.LicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void linkLabelLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }
    }
}
