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

namespace DVLD.Licenses.DetainedLicenses
{
    public partial class frmDetainLicense : Form
    {
        private int _LicenseID = -1;

        public frmDetainLicense()
        {
            InitializeComponent();
        }


        private void tbFineFeesValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            lbDetainDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbCreatedByValue.Text = clsGlobal.CurrentUser.Username;
        }


        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            if (obj == -1)
                return;

            lbLicenseIDValue.Text = obj.ToString();
            linkLabelLicensesHistory.Enabled = true;
            _LicenseID = obj;

            if (DateTime.Compare(DateTime.Now, ctrlDriverLicenseInfoWithFilter1.LicenseInfo.ExpirationDate) > 0)
            {
                MessageBox.Show("This License Expired,Try an detained license", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ctrlDriverLicenseInfoWithFilter1.LicenseInfo.IsActive)
            {
                MessageBox.Show("This license not active,Choose another license", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (ctrlDriverLicenseInfoWithFilter1.LicenseInfo.IsDetained)
            {
                MessageBox.Show("This license already detained,Choose another license", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            btDetain.Enabled = true;

        }


        private void linkLabelLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(ctrlDriverLicenseInfoWithFilter1.LicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
        private void linkLabelLicensesInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDriverLicenseInfo frm = new frmDriverLicenseInfo(_LicenseID);
            frm.ShowDialog();
        }


        private void btDetain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to detain this license ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                int DetainID = ctrlDriverLicenseInfoWithFilter1.LicenseInfo.Detain(
                    Convert.ToDecimal(tbFineFeesValue.Text.Trim()),clsGlobal.CurrentUser.UserID);

                if (DetainID == -1)
                    return;

                MessageBox.Show("Detained Succussfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbDetainIDValue.Text = DetainID.ToString();
                linkLabelLicensesInfo.Enabled = true;
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
                btDetain.Enabled = false;
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
