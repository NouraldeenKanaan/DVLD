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
    public partial class frmRenewLicenseApplications : Form
    {
        private int _NewLicenseID = -1;

        public frmRenewLicenseApplications()
        {
            InitializeComponent();
        }


        private void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        {
            lbApplicationFeesValue.Text = Convert.ToDouble(clsApplicationType.FindByApplicationTypeID((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationTypeFees).ToString();
            lbCreatedByValue.Text = clsGlobal.CurrentUser.Username;
            lbApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbIssueDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            if (obj == -1)
                return;

            lbOldLicenseIDValue.Text = obj.ToString();

            linkLabelLicensesHistory.Enabled = true;
           
            lbExpirationDateValue.Text = DateTime.Now.AddYears(clsLicenseClass.Find(
                ctrlDriverLicenseInfoWithFilter1.LicenseInfo.LicenseClassID).DefaultValidityLength).ToString("dd/MM/yyyy");

            lbLicenseFeesValue.Text = Convert.ToDouble(ctrlDriverLicenseInfoWithFilter1.LicenseInfo.PaidFees).ToString();
            lbTotalFeesValue.Text = (Convert.ToDouble(ctrlDriverLicenseInfoWithFilter1.LicenseInfo.PaidFees) +
            Convert.ToDouble(lbApplicationFeesValue.Text)).ToString();

            if (ctrlDriverLicenseInfoWithFilter1.LicenseInfo.IsActive == false)
            {
                MessageBox.Show($"Selected license isn't active,Try another license","Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.Compare(DateTime.Now, ctrlDriverLicenseInfoWithFilter1.LicenseInfo.ExpirationDate) < 0)
            {
                MessageBox.Show($"Selected license isn't yet expired,It will expire on {ctrlDriverLicenseInfoWithFilter1.LicenseInfo.ExpirationDate.ToString("dd/MM/yyyy")}",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btRenew.Enabled = true;

        }

       

        private void btRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to renew this license ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {

                clsLicense NewLicense = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.RenewLicense(tbNotesValue.Text.Trim(),
                    clsGlobal.CurrentUser.UserID);

                if (NewLicense == null)
                    return;


                MessageBox.Show($"License Renewed Successfully With ID = {NewLicense.LicenseID}", "License Saved", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lbR_L_ApplicationIDValue.Text = NewLicense.ApplicationID.ToString();
                lbRenewedLicenseIDValue.Text = NewLicense.LicenseID.ToString();

                _NewLicenseID = NewLicense.LicenseID;

                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;

                linkLabelRenewLicensesInfo.Enabled = true;

                btRenew.Enabled = false;
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
        private void linkLabelRenewLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }
    }
}
