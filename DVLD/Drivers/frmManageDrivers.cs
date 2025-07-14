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

namespace DVLD.Drivers
{
    public partial class frmManageDrivers : Form
    {
        private DataTable _dtDrivers;

        public frmManageDrivers()
        {
            InitializeComponent();
        }

       
        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _dtDrivers = clsDriver.GetAllDrivers();
            dataGridView1.DataSource = _dtDrivers;

            cbFilterBy.SelectedIndex = 0;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Driver ID";
                dataGridView1.Columns[0].Width = 90;

                dataGridView1.Columns[1].HeaderText = "Person ID";
                dataGridView1.Columns[1].Width = 90;

                dataGridView1.Columns[2].HeaderText = "National No";
                dataGridView1.Columns[2].Width = 90;

                dataGridView1.Columns[3].HeaderText = "Full Name";
                dataGridView1.Columns[3].Width = 235;

                dataGridView1.Columns[4].HeaderText = "Date";
                dataGridView1.Columns[4].Width = 160;
                dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss tt";

                dataGridView1.Columns[5].HeaderText = "Active Licenses";
                dataGridView1.Columns[5].Width = 115;
            }

            lbRecordsValue.Text = dataGridView1.Rows.Count.ToString();
        }


        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Visible = (cbFilterBy.SelectedIndex != 0);

            if (cbFilterBy.SelectedIndex == 0)
            {
                _dtDrivers.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dataGridView1.Rows.Count.ToString();
            }

            if (tbFilterValue.Visible)
            {
                tbFilterValue.Text = "";
                tbFilterValue.Focus();
            }
        }
        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string Filter = "";

            switch (cbFilterBy.SelectedIndex)
            {
                case 0:
                    Filter = "None";
                    break;
                case 1:
                    Filter = "DriverID";
                    break;
                case 2:
                    Filter = "PersonID";
                    break;
                case 3:
                    Filter = "NationalNumber";
                    break;
                case 4:
                    Filter = "FullName";
                    break;
                default:
                    break;
            }

            if (tbFilterValue.Text.Trim() == "" || Filter == "None")
            {
                _dtDrivers.DefaultView.RowFilter = "";
                lbRecordsValue.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            if (Filter == "DriverID" || Filter == "PersonID")
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", Filter, tbFilterValue.Text.Trim());
            else
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", Filter, tbFilterValue.Text.Trim());

            lbRecordsValue.Text = dataGridView1.Rows.Count.ToString();
        }
        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 1 || cbFilterBy.SelectedIndex == 2)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }
    }
}
