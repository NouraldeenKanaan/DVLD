using DVLD.Properties;
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
    public partial class ctrlPersonCardInfo : UserControl
    {
        private int _PersonID = -1;
        public int PersonID
        {
            get { return _PersonID; }
        }

        private clsPerson _Person;
        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCardInfo()
        {
            InitializeComponent();
        }
        
        private void _FillPersonInfo()
        {
            lbPersonIDValue.Text = _Person.PersonID.ToString();
            lbNameValue.Text = _Person.FullName;
            lbNationalNumberValue.Text = _Person.NationalNumber;
            lbAddressValue.Text = _Person.Address;
            lbDateOfBirthValue.Text = _Person.DateOfBirth.ToString("dd/MM/yyyy");
            lbPhoneValue.Text = _Person.Phone;
            lbCountryValue.Text = clsCountry.FindByID(_Person.NationalityCountryID).CountryName;

            if (_Person.Gender == clsPerson.enGender.Male && _Person.ImagePath == "")
            {
                lbGenderValue.Text = "Male";
                pbPersonImage.Image = Resources.Male_512;
            }
            
            if(_Person.Gender == clsPerson.enGender.Female && _Person.ImagePath == "")
            {
                lbGenderValue.Text = "Female";
                pbPersonImage.Image = Resources.Female_512;
            }


            if (_Person.Email == "")
                lbEmailValue.Text = "N/A";
            else
                lbEmailValue.Text = _Person.Email;

            if (_Person.ImagePath != "")
                pbPersonImage.ImageLocation = _Person.ImagePath;

            linklabelEditPersonInfo.Enabled = true;
            
        }


        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.FindByID(PersonID);

            if (_Person == null)
            {
                MessageBox.Show("No Person With PersonID = " + PersonID.ToString());
                return;
            }

            _PersonID = PersonID;

            _FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNumber)
        {        
            _Person = clsPerson.FindByNationalNumber(NationalNumber);

            if (_Person == null)
            {
                MessageBox.Show("No Person With PersonID = " + PersonID.ToString());
                return;
            }
            _PersonID = _Person.PersonID;

            _FillPersonInfo();
        }

        private void linklabelEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmUpdatePerson = new frmAddUpdatePerson(_PersonID);
            frmUpdatePerson.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
        
    }
}
