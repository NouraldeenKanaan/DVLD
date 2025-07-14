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

namespace DVLD.Licenses.LicenseControls
{
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadInternationalLicenseInfo(int InternationalLicenseID)
        {
            clsInternationalLicense InternationalLicense = clsInternationalLicense.FindByID(InternationalLicenseID);

            if (InternationalLicense == null)
            {
                MessageBox.Show("No Data to show", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbNameValue.Text = InternationalLicense.DriverInfo.PersonInfo.FullName;
            lbInt_LicenseIDValue.Text = InternationalLicense.InternationalLicenseID.ToString();
            lbLicenseIDValue.Text = InternationalLicense.IssuedUsingLocalDrivingLicenseID.ToString();
            lbNationalNoValue.Text = InternationalLicense.DriverInfo.PersonInfo.NationalNumber;
            lbGenderValue.Text = InternationalLicense.DriverInfo.PersonInfo.GenderText;
            lbIssueDateValue.Text = InternationalLicense.IssuedDate.ToString("dd/MM/yyyy");
            lbExpirationDateValue.Text = InternationalLicense.ExpirationDate.ToString("dd/MM/yyyy");
            lbApplicationIDValue.Text = InternationalLicense.ApplicationID.ToString();

            if (InternationalLicense.IsActive)
                lbIsActiveValue.Text = "Yes";
            else
                lbIsActiveValue.Text = "No";

            lbDateOfBirthValue.Text = InternationalLicense.DriverInfo.PersonInfo.DateOfBirth.ToString("dd/MM/yyyy");
            lbDriverIDValue.Text = InternationalLicense.DriverID.ToString();

            if (!string.IsNullOrEmpty(InternationalLicense.DriverInfo.PersonInfo.ImagePath))
                pbDriverImage.ImageLocation = InternationalLicense.DriverInfo.PersonInfo.ImagePath;

        }
    }
}
