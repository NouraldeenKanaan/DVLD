using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _TestAppointmentID = -1;

        private int _TestID = -1;
        private clsTest _TestInfo;
        private clsTestType.enTestType _TestTypeID;

        public frmTakeTest(int TestAppointmentID,clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();

            _TestAppointmentID = TestAppointmentID;
            _TestTypeID = TestTypeID;
        }

        

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlTakeTest1.TestTypeID = _TestTypeID;
            ctrlTakeTest1.LoadInfo(_TestAppointmentID, _TestID);

            _HandleTakenTest();
        }


        private void _HandleTakenTest()
        {
            if (_TestID != -1)
            {
                rbPass.Enabled = false;
                rbFail.Enabled = false;
                tbNotesValue.Enabled = false;
                btSave.Enabled = false;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            bool TestResult = false;

            if (rbPass.Checked)
                TestResult = true;
            else
                TestResult = false;

            clsTest Test = ctrlTakeTest1.TestAppointmentInfo.TakeTest(tbNotesValue.Text.Trim(), TestResult, clsGlobal.CurrentUser.UserID);

            if(Test == null)
                MessageBox.Show("Data saved Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            MessageBox.Show("Data saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _TestID = Test.TestID;

            frmTakeTest_Load(null, null);
                  
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
