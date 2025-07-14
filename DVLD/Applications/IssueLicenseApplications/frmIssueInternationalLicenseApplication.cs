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

namespace DVLD.Applications.InternationalLicenseApplication
{
    public partial class frmAddInternationalLicense : Form
    {
        private int _InternationalLicenseID = -1;
        private int _DefaultLicenseLength = 1;

        public frmAddInternationalLicense()
        {
            InitializeComponent();
        }


        private void frmAddInternationalLicense_Load(object sender, EventArgs e)
        {
            lbApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbIssueDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbExpirationDateValue.Text = DateTime.Now.AddYears(_DefaultLicenseLength).ToString("dd/MM/yyyy");
            lbApplicationFeesValue.Text = Convert.ToDouble(clsApplicationType.FindByApplicationTypeID((int)clsApplication
                .enApplicationType.NewInternationalDrivingLicense).ApplicationTypeFees).ToString();
            lbCreatedByValue.Text = clsGlobal.CurrentUser.Username;
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int LicenseID)
        {
            lbLocalLicenseIDValue.Text = LicenseID.ToString();

            linkLabelLicensesHistory.Enabled = (LicenseID != -1);

            if (LicenseID == -1)
                return;



            if (!ctrlDriverLicenseInfoWithFilter1.LicenseInfo.IsActive)
            {
                MessageBox.Show("Your local license not active,Renew and issue an international license", "Not allowed", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (clsInternationalLicense.FindByDriverID(ctrlDriverLicenseInfoWithFilter1.LicenseInfo.DriverID) != null)
            {
                MessageBox.Show("Person already have an active international license", "Not allowed", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            if (ctrlDriverLicenseInfoWithFilter1.LicenseInfo.LicenseClassID != 3)
            {
                MessageBox.Show("Issue International license only for ordinary driving license class", "Not allowed", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

          
            btIssue.Enabled = true;
        }
       

        private void btIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue international license for this driver ? ", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                != DialogResult.OK)
                return;

            clsInternationalLicense InternationalLicense = new clsInternationalLicense();

            InternationalLicense.ApplicantPersonID = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.DriverInfo.PersonID;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            InternationalLicense.PaidFees = clsApplicationType.FindByApplicationTypeID((int)clsApplication.enApplicationType
                .NewInternationalDrivingLicense).ApplicationTypeFees;
            InternationalLicense.LastStatusDate = DateTime.Now;
            InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            InternationalLicense.DriverID = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.DriverID;
            InternationalLicense.IssuedUsingLocalDrivingLicenseID = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.LicenseID;
            InternationalLicense.IssuedDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(_DefaultLicenseLength);


            if (!InternationalLicense.Save())
            {
                MessageBox.Show("Issued Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _InternationalLicenseID = InternationalLicense.InternationalLicenseID;

            linkLabelLicensesInfo.Enabled = true;
            btIssue.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;

            lbI_LicenseIDValue.Text = InternationalLicense.InternationalLicenseID.ToString();
            lbI_L_ApplicationIDValue.Text = InternationalLicense.ApplicationID.ToString();
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void linkLabelLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(ctrlDriverLicenseInfoWithFilter1.LicenseInfo.ApplicationInfo.ApplicantPersonID);
            frm.ShowDialog();
        }
        private void linkLabelLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverInternationalLicenseInfo frm = new frmDriverInternationalLicenseInfo(_InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
