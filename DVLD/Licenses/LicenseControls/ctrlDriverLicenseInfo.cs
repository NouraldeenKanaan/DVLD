using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses.LicenseControls
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LicenseID = -1;
        private clsLicense _LicenseInfo;

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        public int LicenseID { get { return _LicenseID; } }
        public clsLicense LicenseInfo { get { return _LicenseInfo; } }


        public void LoadLicenseData(int LicenseID)
        {
            _LicenseInfo = clsLicense.FindByID(LicenseID);

            if(_LicenseInfo == null)
            {
                MessageBox.Show("No license to show", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LicenseID = LicenseID;

            lbClassValue.Text = _LicenseInfo.LicenseClassInfo.ClassName;
            lbNameValue.Text = _LicenseInfo.ApplicationInfo.ApplicantFullName;
            lbLicenseIDValue.Text = LicenseID.ToString();
            lbNationalNoValue.Text = _LicenseInfo.ApplicationInfo.ApplicantPersonInfo.NationalNumber;
            lbGenderValue.Text = _LicenseInfo.ApplicationInfo.ApplicantPersonInfo.GenderText;
            lbIssueDateValue.Text = _LicenseInfo.IssueDate.ToString("dd/MM/yyyy");
            lbIssueReasonValue.Text = _LicenseInfo.IssueReasonText;

            if (_LicenseInfo.Notes == "")
                lbNotesValue.Text = "No Notes";
            else
                lbNotesValue.Text = _LicenseInfo.Notes;

            if (_LicenseInfo.IsActive)
                lbIsActiveValue.Text = "Yes";
            else
                lbIsActiveValue.Text = "No";


            lbDateOfBirthValue.Text = _LicenseInfo.ApplicationInfo.ApplicantPersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            lbDriverIDValue.Text = _LicenseInfo.DriverID.ToString();
            lbExpirationDateValue.Text = _LicenseInfo.ExpirationDate.ToString("dd/MM/yyyy");

            if (_LicenseInfo.IsDetained)
                lbIsDetainedValue.Text = "Yes";
            else
                lbIsDetainedValue.Text = "No";

            if(_LicenseInfo.ApplicationInfo.ApplicantPersonInfo.ImagePath !=  "")
                pbDriverImage.ImageLocation = _LicenseInfo.ApplicationInfo.ApplicantPersonInfo.ImagePath;

        }
    }
}
