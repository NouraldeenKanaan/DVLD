using DVLD.GlobalClasses;
using DVLD.Properties;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(int PersonID);
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0 , Update = 1};

        private enMode _Mode = enMode.AddNew;

        private int _PersonID = -1;

        clsPerson _PersonInfo;
        


        public frmAddUpdatePerson()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }
        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _PersonID = PersonID;
            _Mode = enMode.Update;
        }


        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();

        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();

            if(_Mode == enMode.AddNew)
            {
                lbTitle.Text = "Add New Person";
                _PersonInfo = new clsPerson();
            }
            else
            {
                lbTitle.Text = "Update Person";
            }

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            cbCountry.SelectedIndex = cbCountry.FindString("Syria");

            lbPersonIDValue.Text = "N/A";
            tbFirstName.Text = "";
            tbSecondName.Text = "";
            tbThirdName.Text = "";
            tbLastName.Text = "";
            tbNationalNumber.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
            pbImage.Image = Resources.Male_512;

            linklabelRemove.Visible = (pbImage.ImageLocation != null);

        }
        private void _LoadData()
        {
            _PersonInfo = clsPerson.FindByID(_PersonID);

            if(_PersonInfo == null)
            {
                MessageBox.Show($"No Person With ID {_PersonID} ,Person Not Found");
                this.Close();
                return;
            }

            lbPersonIDValue.Text = _PersonID.ToString();
            tbFirstName.Text = _PersonInfo.FirstName;
            tbSecondName.Text = _PersonInfo.SecondName;
            tbThirdName.Text = _PersonInfo.ThirdName;
            tbLastName.Text = _PersonInfo.LastName;
            tbNationalNumber.Text = _PersonInfo.NationalNumber;
            dtpDateOfBirth.Value = _PersonInfo.DateOfBirth;
            tbEmail.Text = _PersonInfo.Email;
            tbPhone.Text = _PersonInfo.Phone;
            tbAddress.Text = _PersonInfo.Phone;
            cbCountry.SelectedIndex = cbCountry.FindString(_PersonInfo.NationalityCountryInfo.CountryName);
            

            if (_PersonInfo.Gender == clsPerson.enGender.Male)
            {
                rbMale.Checked = true;
                pbImage.Image = Resources.Male_512;
            }
            else
            {
                rbFemale.Checked = true;
                pbImage.Image = Resources.Female_512;
            }

            if (_PersonInfo.ImagePath != "")
                pbImage.ImageLocation = _PersonInfo.ImagePath;

            linklabelRemove.Visible = (_PersonInfo.ImagePath != "");
        }

            
        private void btSave_Click(object sender, EventArgs e)
        {
            
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valide!,Fill every thing please");
                return;
            }

            _HandlePersonImage();
           
            _PersonInfo.FirstName = tbFirstName.Text.Trim();
            _PersonInfo.SecondName = tbSecondName.Text.Trim();
            _PersonInfo.ThirdName = tbThirdName.Text.Trim();
            _PersonInfo.LastName = tbLastName.Text.Trim();
            _PersonInfo.NationalNumber = tbNationalNumber.Text.Trim();
            _PersonInfo.DateOfBirth = dtpDateOfBirth.Value;
            _PersonInfo.Phone = tbPhone.Text.Trim();
            _PersonInfo.Email = tbEmail.Text.Trim();
            _PersonInfo.Address = tbAddress.Text.Trim();
            _PersonInfo.NationalityCountryID = clsCountry.FindByName(cbCountry.Text).CountryID;

            if (rbMale.Checked)
                _PersonInfo.Gender = clsPerson.enGender.Male;
            else
                _PersonInfo.Gender = clsPerson.enGender.Female;


            if (pbImage.ImageLocation != null)
                _PersonInfo.ImagePath = pbImage.ImageLocation;
            else
                _PersonInfo.ImagePath = "";

            if (_PersonInfo.Save())
            {
                lbPersonIDValue.Text = _PersonInfo.PersonID.ToString();

                _Mode = enMode.Update;
                lbTitle.Text = "Update Person";


                MessageBox.Show("Data Saved Successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                DataBack?.Invoke(_PersonInfo.PersonID);
            }
            else
                MessageBox.Show("Data Saved Failed", "Failed", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);

            if (string.IsNullOrWhiteSpace(Temp.Text.Trim()))
            {
                errorProvider1.SetError(Temp, "This field is required");
            }
            else
            {
                errorProvider1.SetError(Temp,null);
            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }
        private void tbSecondName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }
        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }
        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }
        private void tbAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);
        }
        private void tbNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmptyTextBox(sender, e);

            if (tbNationalNumber.Text.Trim() != _PersonInfo.NationalNumber && clsPerson.IsPersonExist(tbNationalNumber.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNumber, "National Number is used for another person");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNationalNumber, "");
            }
        }
        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (tbEmail.Text.Trim() == "")
                return;

            // Regex for email format, ensuring it ends with .com
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.com$";

            if (!Regex.IsMatch(tbEmail.Text, pattern))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid Email Address Format");
            }
        }
        

        private void linklabelSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = openFileDialog1.FileName;
                pbImage.Load(SelectedFilePath);
                linklabelRemove.Visible = true;
            }

        }
        private void linklabelRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null;

            if (rbMale.Checked)
                pbImage.Image = Resources.Male_512;
            else
                pbImage.Image = Resources.Female_512;

            linklabelRemove.Visible = false;
        }


        private void rbMale_Click(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
                pbImage.Image = Resources.Male_512;
        }
        private void rbFemale_Click(object sender, EventArgs e)
        {
            if (pbImage.ImageLocation == null)
                pbImage.Image = Resources.Female_512;
        }

        private bool _HandlePersonImage()
        {

            if (_PersonInfo.ImagePath != pbImage.ImageLocation)
            {

                if (_PersonInfo.ImagePath != "")
                {

                    try
                    {
                        File.Delete(_PersonInfo.ImagePath);
                    }
                    catch (IOException)
                    { }
                
                }

                if (pbImage.ImageLocation != null)
                {
                    string SourceImageFile = pbImage.ImageLocation.ToString();

                    if (clsUtility.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbImage.ImageLocation = SourceImageFile;
                        return true;
                    }

                }

            }

            return true;
        }
    }
}
