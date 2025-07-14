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

namespace DVLD.Tests
{
    public partial class frmEditTestTypes : Form
    {
        private clsTestType.enTestType _TestTypeID;

        clsTestType _TestTypeInfo;

        public frmEditTestTypes(clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();

            _TestTypeID = TestTypeID;
        }
      

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            _TestTypeInfo = clsTestType.FindByTestTypeID(_TestTypeID);

            if(_TestTypeInfo == null)
            {
                MessageBox.Show("Not Found", "Error");
                this.Close();
                return;
            }

            lbTestTypeIDValue.Text = _TestTypeID.ToString();
            tbTestTypeTitleValue.Text = _TestTypeInfo.TestTypeTitle;
            tbTestTypeDescription.Text = _TestTypeInfo.TestTypeDescription;
            tbTestTypeFeesValue.Text = Convert.ToDouble(_TestTypeInfo.TestTypeFees).ToString();
        }


        private void tbTestTypeTitleValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                tbTestTypeTitleValue.Focus();
            }
            else
                e.Handled = false;
        }
        private void tbTestTypeFeesValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                tbTestTypeFeesValue.Focus();
            }
            else
                e.Handled = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            _TestTypeInfo.TestTypeTitle = tbTestTypeTitleValue.Text.Trim();
            _TestTypeInfo.TestTypeDescription = tbTestTypeDescription.Text.Trim();
            _TestTypeInfo.TestTypeFees = Convert.ToDecimal(tbTestTypeFeesValue.Text);

            if (_TestTypeInfo.Save())
                MessageBox.Show("Test Type Updated Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("Updated Failed", "Failed",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
