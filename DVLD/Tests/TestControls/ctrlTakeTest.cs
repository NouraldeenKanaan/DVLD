using System;
using DVLD.Properties;
using DVLD_Business;
using System.Windows.Forms;

namespace DVLD.Tests.TestControls
{
    public partial class ctrlTakeTest : UserControl
    {
        private clsTestAppointment _TestAppointmentInfo;
        public clsTestAppointment TestAppointmentInfo { get { return _TestAppointmentInfo; } }

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
        
        public ctrlTakeTest()
        {
            InitializeComponent();
        }

        public void LoadInfo(int TestAppointmentID,int TestID = -1)
        {
            _TestAppointmentInfo = clsTestAppointment.FindByAppointmentID(TestAppointmentID);

            if(_TestAppointmentInfo == null)
            {
                MessageBox.Show("Error: No data to load", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbD_L_AppIDValue.Text = _TestAppointmentInfo.LocalDrivingLicenseApplicationID.ToString();
            lbDrivingClassValue.Text = _TestAppointmentInfo.LocalDrivingLicenseApplicationInfo.LicenseClassInfo.ClassName;
            lbNameValue.Text = _TestAppointmentInfo.LocalDrivingLicenseApplicationInfo.ApplicantFullName;
            lbTrialValue.Text = _TestAppointmentInfo.LocalDrivingLicenseApplicationInfo.TotalTrialsPerTestType(_TestTypeID).ToString();
            lbDateValue.Text = _TestAppointmentInfo.AppointmentDate.ToString("dd/MM/yyyy hh:mm tt");
            lbFeesValue.Text = Convert.ToDouble(_TestAppointmentInfo.PaidFees).ToString();

            if(TestID == -1)
                lbTestIDValue.Text = "Not taken yet";
            else
                lbTestIDValue.Text = TestID.ToString();

        }

    }
}
