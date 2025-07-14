using DVLD.Properties;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Tests.TestControls
{
    public partial class ctrlScheduleTest : UserControl
    {
        public enum enCreationMode { FirstTimeSchedule = 0, RetakeTest = 1 };
        public enum enMode { AddNew = 0, Update = 1 };

        private enMode _Mode = enMode.AddNew;
        private enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;


        private int _LocalDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;
        private int _TestAppointmentID = -1;
        private clsTestAppointment _TestAppointment;

        private clsTestType.enTestType _TestTypeID = clsTestType.enTestType.VisionTest;
        public clsTestType.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set
            {
                _TestTypeID = value;

                switch (_TestTypeID)
                {
                    case clsTestType.enTestType.VisionTest:
                        gbTestMode.Text = "Vision Test";
                        lbTitle.Text = "Vision Test";
                        pbHeader.Image = Resources.Vision_512;
                        break;
                    case clsTestType.enTestType.WrittenTest:
                        gbTestMode.Text = "Written Test";
                        lbTitle.Text = "Written Test";
                        pbHeader.Image = Resources.Written_Test_512;
                        break;
                    case clsTestType.enTestType.StreetTest:
                        gbTestMode.Text = "Street Test";
                        lbTitle.Text = "Street Test";
                        pbHeader.Image = Resources.Street_Test_32;
                        break;
                }

            }
        }


        public ctrlScheduleTest()
        {
            InitializeComponent();
        }



        public void LoadInfo(int LocalDrivingLicenseApplicationID, int TestAppointmentID = -1)
        {
            if (TestAppointmentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;


            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _TestAppointmentID = TestAppointmentID;
            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByID(LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btSave.Enabled = false;
                return;
            }


            if (_LocalDrivingLicenseApplication.DoesAttendForTestType(_TestTypeID))
                _CreationMode = enCreationMode.RetakeTest;
            else
                _CreationMode = enCreationMode.FirstTimeSchedule;


            lbD_L_AppIDValue.Text = _LocalDrivingLicenseApplicationID.ToString();
            lbDrivingClassValue.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            lbNameValue.Text = _LocalDrivingLicenseApplication.ApplicantFullName;
            lbFeesValue.Text = Convert.ToDouble(clsTestType.FindByTestTypeID(_TestTypeID).TestTypeFees).ToString();
            


            if (_CreationMode == enCreationMode.RetakeTest)
            {
                lbTitle.Text = "Schedule Retake Test";
                gbRetakeTestInfo.Enabled = true;

                lbRetakeTestAppFeesValue.Text = Convert.ToDouble(clsApplicationType.FindByApplicationTypeID((int)clsApplication.enApplicationType.RetakeTest).ApplicationTypeFees).ToString();
                lbTotalFeesValue.Text = (Convert.ToDouble(lbFeesValue.Text) + Convert.ToDouble(lbRetakeTestAppFeesValue.Text)).ToString();
            }
            else
            {
                lbTitle.Text = "Schedule Test";
                gbRetakeTestInfo.Enabled = false;
            }


            if (_Mode == enMode.AddNew)
            {
                dateTimePicker1.MinDate = DateTime.Now;

                _TestAppointment = new clsTestAppointment();
            }
            else
            {
                if (!_LoadTestAppointmentData())
                    return;
            }


            lbTrialValue.Text = _LocalDrivingLicenseApplication.TotalTrialsPerTestType(_TestTypeID).ToString();


            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

        }



        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = clsTestAppointment.FindByAppointmentID(_TestAppointmentID);

            if(_TestAppointment == null)
            {
                MessageBox.Show($"Error: No Appointment With {_TestAppointmentID} ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btSave.Enabled = false;
                return false;
            }

            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dateTimePicker1.MinDate = DateTime.Now;
            else
                dateTimePicker1.MinDate = _TestAppointment.AppointmentDate;

            dateTimePicker1.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationID != -1)
                lbRetakeTestAppIDValue.Text = _TestAppointment.RetakeTestApplicationID.ToString();
            else
            {
                lbRetakeTestAppIDValue.Text = "N/A";
                lbRetakeTestAppFeesValue.Text = "0";
                lbTotalFeesValue.Text = lbFeesValue.Text;
            }

            return true;
        }

        private bool _HandleActiveTestAppointmentConstraint()
        {
            if (_Mode == enMode.AddNew && _LocalDrivingLicenseApplication.IsThereAnActiveScheduleTest(_TestTypeID))
            {
                lbUserMessage.Text = "Person Already have an active appointment for this test";
                btSave.Enabled = false;
                dateTimePicker1.Enabled = false;
                return false;
            }

            return true;
        }
        private bool _HandleRetakeTest()
        {
            if (_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTest)
            {

                clsApplication RetakeApplication = new clsApplication();

                RetakeApplication.ApplicantPersonID = _LocalDrivingLicenseApplication.ApplicantPersonID;
                RetakeApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.RetakeTest;
                RetakeApplication.ApplicationDate = DateTime.Now;
                RetakeApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
                RetakeApplication.PaidFees = clsApplicationType.FindByApplicationTypeID((int)clsApplication.enApplicationType.RetakeTest).ApplicationTypeFees;
                RetakeApplication.LastStatusDate = DateTime.Now;
                RetakeApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (RetakeApplication.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = RetakeApplication.ApplicationID;
                }

            }
            return true;
            
        }
        private bool _HandleAppointmentLockedConstraint()
        {
            if (_TestAppointment.IsLocked) 
            {
                lbTitle.Text = "Schedule Retake Test";

                lbUserMessage.Visible = true;
                dateTimePicker1.Enabled = false;
                btSave.Enabled = false;

                return false;
            }

            return true;
        }



        private void btSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeTest())
                return;

            if (_CreationMode == enCreationMode.RetakeTest)
                _TestAppointment.PaidFees = Convert.ToDecimal(lbTotalFeesValue.Text);
            else
                _TestAppointment.PaidFees = Convert.ToDecimal(lbFeesValue.Text);


            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.AppointmentDate = dateTimePicker1.Value;
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ParentForm.Close();
            }
            else
            {
                MessageBox.Show("Data Saved Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
