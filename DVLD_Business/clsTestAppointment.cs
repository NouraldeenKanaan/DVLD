using DVLD_Business;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestAppointment
    {
        public enum enMode  { AddNew = 0 , Update = 1 };

        public enMode Mode = enMode.AddNew;
        public int TestAppointmentID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }

        public clsLocalDrivingLicenseApplication LocalDrivingLicenseApplicationInfo;
        public clsTestType.enTestType TestTypeID { get; set; }

        public clsTestType TestTypeInfo;
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clsUser CreatedByUserInfo;
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }

        public clsApplication RetakeApplicationInfo;


        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.LocalDrivingLicenseApplicationID = -1;
            this.TestTypeID = clsTestType.enTestType.VisionTest;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;

            Mode = enMode.AddNew;
        }
        private clsTestAppointment(int TestAppointmentID, int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked,int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.LocalDrivingLicenseApplicationInfo = clsLocalDrivingLicenseApplication.FindByID(LocalDrivingLicenseApplicationID);
            this.TestTypeID = TestTypeID;
            this.TestTypeInfo = clsTestType.FindByTestTypeID(TestTypeID);
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            this.RetakeApplicationInfo = clsApplication.FindBaseApplication(RetakeTestApplicationID);

            Mode = enMode.Update;
        }


        public static clsTestAppointment FindByAppointmentID(int TestAppointmentID)
        {
            int LocalDrivingLicenseApplicationID = -1, TestTypeID = -1, CreatedByUserID = -1, RetakeTestApplicationID = -1;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0;
            bool IsLocked = true;

            if (clsTestAppointmentsData.GetTestAppointmentInfoByID(TestAppointmentID, ref LocalDrivingLicenseApplicationID, ref TestTypeID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked,ref RetakeTestApplicationID))
                return new clsTestAppointment(TestAppointmentID, LocalDrivingLicenseApplicationID, (clsTestType.enTestType)TestTypeID, AppointmentDate, PaidFees,
                    CreatedByUserID, IsLocked,RetakeTestApplicationID);
            else
                return null;

        }
       
        
        public static DataTable GetTestAppointmentPerTestType(int LocalDrivingLicenseApplicationID,clsTestType.enTestType TestTypeID)
        {
            return clsTestAppointmentsData.GetApplicationTestAppointmentPerTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        


        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentsData.AddNewTestAppointment(this.LocalDrivingLicenseApplicationID, (int)this.TestTypeID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }
        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentsData.UpdateTestAppointment(this.TestAppointmentID, this.LocalDrivingLicenseApplicationID, (int)this.TestTypeID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked,this.RetakeTestApplicationID);
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewTestAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateTestAppointment();
            }

            return false;
        }

        public clsTest TakeTest(string Notes,bool TestReult,int CreatedByUserID)
        {
            clsTest TakeTest = new clsTest();

            TakeTest.TestAppointmentID = this.TestAppointmentID;
            TakeTest.Notes = Notes;
            TakeTest.TestResult = TestReult;
            TakeTest.CreatedByUserID = CreatedByUserID;

            if (!TakeTest.Save())
                return null;

            this.IsLocked = true;

            if (!this.Save())
                return null;

            return TakeTest;
        }
    }
}
