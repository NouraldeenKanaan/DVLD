using DVLD.People;
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

namespace DVLD.Controls
{
    public partial class ctrlPersonCardInfoWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;

            if(handler != null)
            {
                handler(PersonID);
            }
        }


        private bool _ShowAddPerson = true;
        public bool ShowAddNewPerson
        {
            get { return _ShowAddPerson; }
            set { _ShowAddPerson = value; btAddNewPerson.Enabled = _ShowAddPerson; }
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set { _FilterEnabled = value; gbFilter.Enabled = _FilterEnabled; }
        }

        private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrlPersonCardInfo1.PersonID; }
        }
        public clsPerson SelectedPersonInfo
        {
            get { return ctrlPersonCardInfo1.SelectedPersonInfo; }
        }


        public ctrlPersonCardInfoWithFilter()
        {
            InitializeComponent();
        }


        private void ucPersonCardInfoWithFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }
        public void LoadPersonInfo(int PersonID)
        {
            cbFilter.SelectedIndex = 0;
            tbFilterValue.Text = PersonID.ToString();
            _PersonID = PersonID;
            _FindNow();
        }
        private void _FindNow()
        {
            switch(cbFilter.SelectedIndex)
            {
                case 0:
                    ctrlPersonCardInfo1.LoadPersonInfo(int.Parse(tbFilterValue.Text));
                    break;
                case 1:
                    ctrlPersonCardInfo1.LoadPersonInfo(tbFilterValue.Text);
                    break;
                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnabled)
                OnPersonSelected(ctrlPersonCardInfo1.PersonID);

        }


        private void btFindPerson_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields are not valid", "Error");
                return;
            }
            _FindNow();
        }
        private void btAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }


        private void DataBackEvent(int PersonID)
        {
            cbFilter.SelectedIndex = 0;
            tbFilterValue.Text = PersonID.ToString();
            ctrlPersonCardInfo1.LoadPersonInfo(PersonID);
        }


        private void tbFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFilterValue, "This Field Is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFilterValue, null);
            }
        }
        private void tbFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btFindPerson.PerformClick();
                e.Handled = true;
            }
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterValue.Text = "";
            tbFilterValue.Focus();
        }
    }
}
