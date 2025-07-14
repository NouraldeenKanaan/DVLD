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
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;
        protected virtual void LicenseSelected(int LicenseID)
        {
            Action<int> handler = OnLicenseSelected;

            if (handler != null)
                handler(LicenseID);

        }


        private clsLicense _LicenseInfo;
        public clsLicense LicenseInfo { get { return _LicenseInfo; } }

        private bool _FilterEnabled = true;
        public bool FilterEnabled { set { _FilterEnabled = value; } get { return gbFilter.Enabled = _FilterEnabled; } }

        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }



        private void tbLicenseIDValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Enter)
            {
                btFindLicense.PerformClick();
                e.Handled = true;
            }
        }
        private void btFindLicense_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLicenseIDValue.Text))
            {
                MessageBox.Show("Please enter an ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LicenseInfo = clsLicense.FindByID(Convert.ToInt32(tbLicenseIDValue.Text));

            if(_LicenseInfo == null)
            {
                MessageBox.Show($"No License with LicenseID = {tbLicenseIDValue.Text}", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ctrlDriverLicenseInfo1.LoadLicenseData(_LicenseInfo.LicenseID);

            if (OnLicenseSelected != null)
                OnLicenseSelected(_LicenseInfo.LicenseID);
        }


        public void LoadInfo(int LicenseID)
        {
            _LicenseInfo = clsLicense.FindByID(LicenseID);

            if (_LicenseInfo == null)
            {
                MessageBox.Show($"No License with LicenseID = {LicenseID}", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbLicenseIDValue.Text = LicenseID.ToString();
            ctrlDriverLicenseInfo1.LoadLicenseData(LicenseID);
            gbFilter.Enabled = false;

            if (OnLicenseSelected != null)
                OnLicenseSelected(LicenseID);
        }
    }
}
