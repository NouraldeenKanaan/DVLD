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

namespace DVLD.Applications
{
    public partial class frmManageApplicationTypes : Form
    {
        private static DataTable _AllApplicationTypes;

        public frmManageApplicationTypes()
        {
            InitializeComponent();
        }

       
        private void frmManageApplicationTypes_Load(object sender, EventArgs e)
        {
            _AllApplicationTypes = clsApplicationType.GetAllApplicationTypes();

            dgvApplicationTypesList.DataSource = _AllApplicationTypes;

            if (dgvApplicationTypesList.Rows.Count > 0)
            {
                dgvApplicationTypesList.Columns[0].HeaderText = "A.T.ID";
                dgvApplicationTypesList.Columns[1].HeaderText = "A.T.Name";
                dgvApplicationTypesList.Columns[2].HeaderText = "A.T.Fees";

                dgvApplicationTypesList.Columns[0].Width = 100;
                dgvApplicationTypesList.Columns[1].Width = 365;
                dgvApplicationTypesList.Columns[2].Width = 100;
            }

            lbRecordsValue.Text = dgvApplicationTypesList.Rows.Count.ToString();

        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationTypes frm = new frmEditApplicationTypes((int)dgvApplicationTypesList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageApplicationTypes_Load(null, null);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
