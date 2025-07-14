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

namespace DVLD.People
{
    public partial class frmManagePeople : Form
    {
        private static DataTable _AllPeople;

        public frmManagePeople()
        {
            InitializeComponent();
        }


        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _AllPeople = clsPerson.GetAllPeople();

            dgvPeopleList.DataSource = _AllPeople;

            cbFilter.SelectedIndex = 0;

            if (dgvPeopleList.Rows.Count > 0)
            {
                dgvPeopleList.Columns[0].HeaderText = "Person ID";
                dgvPeopleList.Columns[0].Width = 100;

                dgvPeopleList.Columns[1].HeaderText = "National Number";
                dgvPeopleList.Columns[1].Width = 130;

                dgvPeopleList.Columns[2].HeaderText = "First Name";
                dgvPeopleList.Columns[2].Width = 130;

                dgvPeopleList.Columns[3].HeaderText = "Second Name";
                dgvPeopleList.Columns[3].Width = 130;

                dgvPeopleList.Columns[4].HeaderText = "Third Name";
                dgvPeopleList.Columns[4].Width = 120;

                dgvPeopleList.Columns[5].HeaderText = "Last Name";
                dgvPeopleList.Columns[5].Width = 120;

                dgvPeopleList.Columns[6].HeaderText = "Gender";
                dgvPeopleList.Columns[6].Width = 90;

                dgvPeopleList.Columns[7].HeaderText = "Date Of Birth";
                dgvPeopleList.Columns[7].Width = 140;
                dgvPeopleList.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvPeopleList.Columns[8].HeaderText = "Nationality";
                dgvPeopleList.Columns[8].Width = 120;

                dgvPeopleList.Columns[9].HeaderText = "Phone";
                dgvPeopleList.Columns[9].Width = 140;

                dgvPeopleList.Columns[10].HeaderText = "Email";
                dgvPeopleList.Columns[10].Width = 150;
            }

            lbRecordsResult.Text = dgvPeopleList.Rows.Count.ToString();

        }
        

        private void _AddNewPerson()
        {
            Form frmAddNewPerson = new frmAddUpdatePerson();
            frmAddNewPerson.ShowDialog();
            frmManagePeople_Load(null, null);
        }
        private void btAddNewPerson_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Visible = (cbFilter.SelectedIndex != 0);

            if (cbFilter.SelectedIndex == 0)
            {
                _AllPeople.DefaultView.RowFilter = "";
                lbRecordsResult.Text = dgvPeopleList.Rows.Count.ToString();
            }


            if (tbFilterValue.Visible)
            {
                tbFilterValue.Text = "";
                tbFilterValue.Focus();
            }
        }
        private void tbFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilter.SelectedIndex)
            {
                case 1:
                    FilterColumn = "PersonID";
                    break;
                case 2:
                    FilterColumn = "NationalNumber";
                    break;
                case 3:
                    FilterColumn = "FirstName";
                    break;
                case 4:
                    FilterColumn = "SecondName";
                    break;
                case 5:
                    FilterColumn = "ThirdName";
                    break;
                case 6:
                    FilterColumn = "LastName";
                    break;
                case 7:
                    FilterColumn = "CountryName";
                    break;
                case 8:
                    FilterColumn = "GenderCaption";
                    break;
                case 9:
                    FilterColumn = "PhoneNumber";
                    break;
                case 10:
                    FilterColumn = "Email";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (tbFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _AllPeople.DefaultView.RowFilter = "";
                lbRecordsResult.Text = dgvPeopleList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                _AllPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, tbFilterValue.Text.Trim());
            else
                _AllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, tbFilterValue.Text.Trim());

            lbRecordsResult.Text = dgvPeopleList.Rows.Count.ToString();
        }
        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 1)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

       

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            frmShowPersonDetails frmShowPersonCard = new frmShowPersonDetails((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frmShowPersonCard.ShowDialog();
            frmManagePeople_Load(null, null);
        }
        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this person ? ", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPerson.DeletePerson((int)dgvPeopleList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully","Succeeded",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmManagePeople_Load(null, null);
                }
                MessageBox.Show("Person was not Deleted Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void tsmPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Emplimented Yet", "NULL");
        }
        private void tsmSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Emplimented Yet", "NULL");

        }
        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            _AddNewPerson();
        }
        private void tsmEdit_Click(object sender, EventArgs e)
        {
            Form frmEditPerson = new frmAddUpdatePerson((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frmEditPerson.ShowDialog();
            frmManagePeople_Load(null, null);
        }
    }
}
