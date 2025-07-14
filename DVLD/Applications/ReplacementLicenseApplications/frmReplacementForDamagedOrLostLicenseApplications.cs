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
    public partial class frmReplacementForDamagedOrLostLicenseApplications : Form
    {
        private int _LicenseID = -1;

        public frmReplacementForDamagedOrLostLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmReplacementForDamagedOrLostLicenseApplication_Load(object sender, EventArgs e)
        {
            rbDamagedLicense.Checked = true;
            lbApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbCreatedByValue.Text = clsGlobal.CurrentUser.Username;
        }



        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Replacement for Damaged License";
            lbTitle.Text = "Replacement for Damaged License";
            lbApplicationFeesValue.Text = Convert.ToDouble(clsApplicationType.FindByApplicationTypeID
                ((int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense).ApplicationTypeFees).ToString();
        }
        private void tbLostlicense_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Replacement for Lost License";
            lbTitle.Text = "Replacement for Lost License";
            lbApplicationFeesValue.Text = Convert.ToDouble(clsApplicationType.FindByApplicationTypeID
                ((int)clsApplication.enApplicationType.ReplaceLostDrivingLicense).ApplicationTypeFees).ToString();
        }


        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            if (obj == -1)
                return;

            lbOldLicenseIDValue.Text = obj.ToString();
            linkLabelLicensesHistory.Enabled = true;

            if (ctrlDriverLicenseInfoWithFilter1.LicenseInfo.IsActive == false)
            {
                MessageBox.Show($"Selected license isn't active,Try another active license", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LicenseID = obj;

            btIssueReplacement.Enabled = true;

        }

        private void linkLabelLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(ctrlDriverLicenseInfoWithFilter1.LicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void linkLabelRenewLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }



        private void btIssueReplacement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to renew this license ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {

                clsLicense NewLicense = new clsLicense();

                if (rbDamagedLicense.Checked)
                {
                    NewLicense = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.Replace(clsLicense.enIssueReason.DamagedReplcement,clsGlobal.CurrentUser.UserID);
                    MessageBox.Show($"License Renewed Successfully With ID = {NewLicense.LicenseID}", "License Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    NewLicense = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.Replace(clsLicense.enIssueReason.LostReplacement,clsGlobal.CurrentUser.UserID);
                    MessageBox.Show($"License Renewed Successfully With ID = {NewLicense.LicenseID}", "License Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }

                if (NewLicense == null)
                    return;


                lbL_R_ApplicationIDValue.Text = NewLicense.ApplicationID.ToString();
                lbNewLicenseIDValue.Text = NewLicense.LicenseID.ToString();

                _LicenseID = NewLicense.LicenseID;

                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
                linkLabelnewLicensesInfo.Enabled = true;

                btIssueReplacement.Enabled = false;
            }
            
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
