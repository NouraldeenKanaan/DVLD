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
    public partial class frmManageTestTypes : Form
    {
        private static DataTable _AllTestTypes;
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        
        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _AllTestTypes = clsTestType.GetAllTestTypes();

            dgvTestTypesList.DataSource = _AllTestTypes;

            if (dgvTestTypesList.Rows.Count > 0)
            {
                dgvTestTypesList.Columns[0].HeaderText = "T.T.ID";
                dgvTestTypesList.Columns[1].HeaderText = "T.T.Title";
                dgvTestTypesList.Columns[2].HeaderText = "T.T.Description";
                dgvTestTypesList.Columns[3].HeaderText = "T.T.Fees";

                dgvTestTypesList.Columns[0].Width = 60;
                dgvTestTypesList.Columns[1].Width = 175;
                dgvTestTypesList.Columns[2].Width = 425;
                dgvTestTypesList.Columns[3].Width = 73;

            }

            lbRecordsValue.Text = dgvTestTypesList.Rows.Count.ToString();
        }

        private void editTypeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestTypes frm = new frmEditTestTypes((clsTestType.enTestType)dgvTestTypesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageTestTypes_Load(null, null);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
