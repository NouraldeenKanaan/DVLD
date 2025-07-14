using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Applications
{
    public partial class frmEditApplicationTypes : Form
    {
        private int _ApplicationTypeID = -1;

        private clsApplicationType _ApplicationType;

        public frmEditApplicationTypes(int ApplicationTypeID)
        {
            InitializeComponent();

            this._ApplicationTypeID = ApplicationTypeID;
        }


        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            _ApplicationType = clsApplicationType.FindByApplicationTypeID(_ApplicationTypeID);

            if (_ApplicationType == null)
            {
                MessageBox.Show("Not Found", "Error");
                this.Close();
                return;
            }

            lbApplicationTypeIDValue.Text = _ApplicationTypeID.ToString();
            tbApplicationTypeNameValue.Text = _ApplicationType.ApplicationTypeName;
            tbApplicationTypeFeesValue.Text = Convert.ToDouble(_ApplicationType.ApplicationTypeFees).ToString();

        }


        private void tbApplicationTypeNameValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                tbApplicationTypeNameValue.Focus();
            }
            else
                e.Handled = false;
        }
        private void tbApplicationTypeFeesValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                tbApplicationTypeFeesValue.Focus();
            }
            else
                e.Handled = false;
        }

        

        private void btSave_Click(object sender, EventArgs e)
        {
            _ApplicationType.ApplicationTypeName = tbApplicationTypeNameValue.Text.Trim();
            _ApplicationType.ApplicationTypeFees = Convert.ToDecimal(tbApplicationTypeFeesValue.Text.Trim());

            if (_ApplicationType.Save())
                MessageBox.Show("Application Type Updated Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Updated Failed", "Failed",MessageBoxButtons.OK,MessageBoxIcon.Stop);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}
