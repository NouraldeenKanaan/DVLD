using System;
using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsPerson
    {
        enum enMode { AddNew = 0 , Update = 1};
        public enum enGender { Male = 0, Female = 1 };
        enMode Mode = enMode.Update;

        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; } }
        public DateTime DateOfBirth { get; set; }
        public enGender Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int NationalityCountryID { get; set; }

        public clsCountry NationalityCountryInfo;

        private string _ImagePath;
        public string ImagePath { get { return _ImagePath; } set { _ImagePath = value; } }
        public string GenderText 
        {
            get
            {
                if (Gender == enGender.Male)
                    return "Male";
                else
                    return "Female";
            }
        }


        public clsPerson()
        {
           this.PersonID = -1;
           this.NationalNumber = "";
           this.FirstName = "";
           this.SecondName = "";
           this.ThirdName = "";
           this.LastName = "";
           this.DateOfBirth = DateTime.Now;
           this.Gender = enGender.Male;
           this.Phone = "";
           this.Email = "";
           this.Address = "";
           this.NationalityCountryID = -1;
           this.ImagePath = "";

            Mode = enMode.AddNew;
        }
        private clsPerson(int PersonID,string NationalNumber,string FirstName,string SecondName,string ThirdName,string LastName,
                         DateTime DateOfBirth,enGender Gender,string Phone,string Email,string Address,int NationalCountryID,string ImagePath) 
        {
            this.PersonID = PersonID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.NationalityCountryID = NationalCountryID;
            this.NationalityCountryInfo = clsCountry.FindByID(NationalCountryID);
            this.ImagePath = ImagePath;

            Mode = enMode.Update;
        }


        public static DataTable GetAllPeople()
        {
            return clsPeopleData.GetAllPeople();
        }


        public static bool IsPersonExist(string NationalNumber)
        {
            return clsPeopleData.IsPersonExist(NationalNumber);
        }

        public static clsPerson FindByID(int PersonID)
        {
            string NationalNumber = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Phone = "", Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            int NationalCountryID = -1;

            if (clsPeopleData.GetPersonInfoByID(PersonID, ref NationalNumber, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth,ref Gender, ref Phone, ref Email, ref Address, ref NationalCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth, (enGender)Gender, Phone, Email, Address, NationalCountryID, ImagePath);
            }
            else
                return null;

        }
        public static clsPerson FindByNationalNumber(string NationalNumber)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Phone = "", Email = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gender = 0;
            int NationalCountryID = -1, PersonID = -1;

            if (clsPeopleData.GetPersonInfoByNationalNumber(NationalNumber,ref PersonID,ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref DateOfBirth, ref Gender, ref Phone, ref Email, ref Address, ref NationalCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, DateOfBirth,(enGender)Gender, Phone, Email, Address, NationalCountryID, ImagePath);
            }
            else
                return null;

        }


        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleData.AddNewPerson(this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, (byte)this.Gender, this.Phone, this.Email, this.Address, this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsPeopleData.UpdatePerson(this.PersonID, this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, (byte)this.Gender, this.Phone, this.Email, this.Address, this.NationalityCountryID, this.ImagePath);
        }
        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleData.DeletePerson(PersonID);
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                        break;
                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }
    }
}
