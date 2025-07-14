using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class frmAddUpdateLocalDrivingLicenseApplications : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int _D_L_LApplicationID = -1;
        private int _SelectedPersonID = -1;

        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;


        public frmAddUpdateLocalDrivingLicenseApplications()
        {
            InitializeComponent();

            Mode = enMode.AddNew;
        }
        public frmAddUpdateLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();

            _D_L_LApplicationID = LocalDrivingLicenseApplicationID;
            Mode = enMode.Update;
        }


        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (Mode == enMode.Update)
                _LoadData();
        }


        private void _FillClassesInComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();

            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cbLicenseClasses.Items.Add(row["ClassName"]);
            }

        }
        private void _ResetDefaultValues()
        {
            if (Mode == enMode.AddNew)
            {
                lbTitle.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
            }
            else
                lbTitle.Text = "Update Local Driving License Application";


            _FillClassesInComboBox();
            cbLicenseClasses.SelectedIndex = 2;

            lbApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
            lbApplicationFeesValue.Text = Convert.ToDouble(clsApplicationType.FindByApplicationTypeID(
                (int)clsApplication.enApplicationType.NewDrivingLicense).ApplicationTypeFees).ToString();
            lbCreatedByValue.Text = clsGlobal.CurrentUser.Username;
        }
        private void _LoadData()
        {
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByID(_D_L_LApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No data to show", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlPersonCardInfoWithFilter1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicantPersonID);
            ctrlPersonCardInfoWithFilter1.FilterEnabled = false;

            lbApplicationIDValue.Text = _D_L_LApplicationID.ToString();
            lbApplicationDateValue.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToString("dd/MM/yyyy");

            cbLicenseClasses.SelectedItem = cbLicenseClasses.FindString(clsLicenseClass.Find(_LocalDrivingLicenseApplication.LicenseClassID).ClassName);
            cbLicenseClasses.Enabled = false;

            lbApplicationFeesValue.Text = Convert.ToDouble(_LocalDrivingLicenseApplication.PaidFees).ToString();

            clsApplication BaseApplication = clsApplication.FindBaseApplication(_LocalDrivingLicenseApplication.ApplicationID);
            lbCreatedByValue.Text = BaseApplication.CreatedByUserInfo.Username;
       
            btSave.Enabled = false;
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            int LicenseClassID = clsLicenseClass.Find(cbLicenseClasses.Text).LicenseClassID;

            int ActiveApplicationID = clsApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonID,
                clsApplication.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another license class,The selected person already have an active appliction for this license class",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(clsLicense.IsLicenseExistByPersonID(_SelectedPersonID,LicenseClassID))
            {
                MessageBox.Show("This person already have license with the same license class,Try another license class", "Not allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _LocalDrivingLicenseApplication.ApplicantPersonID = _SelectedPersonID;
            _LocalDrivingLicenseApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.NewDrivingLicense;
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.PaidFees = Convert.ToDecimal(lbApplicationFeesValue.Text);
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;
         
            if (_LocalDrivingLicenseApplication.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Mode = enMode.Update;
                lbTitle.Text = "Update Local Driving License Application";

                lbApplicationIDValue.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                ctrlPersonCardInfoWithFilter1.FilterEnabled = false;
                btSave.Enabled = false;
                cbLicenseClasses.Enabled = false;

                return;
            }
            else
                MessageBox.Show("Data Saved Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardInfoWithFilter1.PersonID != -1)
                tabControl1.SelectedTab = tabpageApplicationInfo;
            else
                MessageBox.Show("Please add a person", "Error");
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ucPersonCardInfoWithFilter1_OnPersonSelected(int obj)
        {
            if (obj == -1)
                return;

            _SelectedPersonID = obj;
            btSave.Enabled = true;
        }
    }
}
