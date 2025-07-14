using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Tests.TestAppointments
{
    public partial class frmTestAppointments : Form
    {
        private static DataTable _dtLicenseTestAppointments;
        private clsTestType.enTestType _TestTypeID;
        private int _LocalDrivingLicenseApplicationID = -1;


        public frmTestAppointments(int LocalDrivingLicenseApplicationID,clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();

            this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this._TestTypeID = TestTypeID;
        }


        private void _VisionTest()
        {
            this.Text = "Vision Test Appointments";
            lbTitle.Text = "Vision Test Appointments";
            pictureBox1.Image = Resources.Vision_512;
        }
        private void _WrittenTest()
        {
            this.Text = "Written Test Appointments";
            lbTitle.Text = "Written Test Appointments";
            pictureBox1.Image = Resources.Written_Test_512;
        }
        private void _StreetTest()
        {
            this.Text = "Street Test Appointments";
            lbTitle.Text = "Street Test Appointments";
            pictureBox1.Image = Resources.Street_Test_32;
        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {
            switch (_TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    _VisionTest();
                    break;
                case clsTestType.enTestType.WrittenTest:
                    _WrittenTest();
                    break;
                case clsTestType.enTestType.StreetTest:
                    _StreetTest();
                    break;
                default:
                    break;
            }


            ctrlLocalDrivingApplicationInfoCard1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicenseApplicationID);

            _dtLicenseTestAppointments = clsTestAppointment.GetTestAppointmentPerTestType(_LocalDrivingLicenseApplicationID,_TestTypeID);

            dgvAppointments.DataSource = _dtLicenseTestAppointments;

            if (dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvAppointments.Columns[3].HeaderText = "Is Locked";

                dgvAppointments.Columns[0].Width = 150;
                dgvAppointments.Columns[1].Width = 275;
                dgvAppointments.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm tt";
                dgvAppointments.Columns[2].Width = 150;
                dgvAppointments.Columns[3].Width = 150;

            }

            lbRecordsValue.Text = dgvAppointments.Rows.Count.ToString();
        }


        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btAddAppointment_Click(object sender, EventArgs e)
        {
            if (ctrlLocalDrivingApplicationInfoCard1.LocalDrivingLicenseApplication.IsThereAnActiveScheduleTest(_TestTypeID))
            {
                MessageBox.Show("Person already have an active appointment for this test, you can't add a new appointment",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if(ctrlLocalDrivingApplicationInfoCard1.LocalDrivingLicenseApplication.DoesPassTestType(_TestTypeID))
            {
                MessageBox.Show("Person already passed this test, you can't add a new appointment",
                    "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            frmScheduleTests frm = new frmScheduleTests(_LocalDrivingLicenseApplicationID,_TestTypeID);
            frm.ShowDialog();

            frmTestAppointments_Load(null, null);
        }


        private void tsmTestEdit_Click(object sender, EventArgs e)
        {
            frmScheduleTests frmEdit = new frmScheduleTests(_LocalDrivingLicenseApplicationID,_TestTypeID, (int)dgvAppointments.CurrentRow.Cells[0].Value);
            frmEdit.ShowDialog();

            frmTestAppointments_Load(null, null);
        }
        private void tsmTakeTest_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest((int)dgvAppointments.CurrentRow.Cells[0].Value,_TestTypeID);
            frm.ShowDialog();

            frmTestAppointments_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            tsmTakeTest.Enabled = !clsTestAppointment.FindByAppointmentID((int)dgvAppointments.CurrentRow.Cells[0].Value).IsLocked;
        }
    }
}
