using DVLD_Business;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_Business
{
    public class clsLocalDrivingLicenseApplication:clsApplication
    {
        public enum enMode { AddNew = 0 , Update = 1};

        public enMode Mode = enMode.AddNew; 

        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLicenseClass LicenseClassInfo;

        public clsLocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationTypeID = -1;
            ApplicationDate = DateTime.Now;
            ApplicationStatus = enApplicationStatus.New;
            PaidFees = 0;
            LastStatusDate = DateTime.Now;
            CreatedByUserID = -1;
            LicenseClassID = -1;

            Mode = enMode.AddNew;
        }
        private clsLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID,int ApplicationID,int ApplicantPersonID,int ApplicationTypeID,
            DateTime ApplicationDate,enApplicationStatus ApplicationStatus,decimal PaidFees,DateTime LastStatusDate,int CreatedByUserID,int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationStatus = ApplicationStatus;
            this.PaidFees = PaidFees;
            this.LastStatusDate = LastStatusDate;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);


            Mode = enMode.Update;
        }


        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationsData.GetAllLocalDrivingLicenseApplications();
        }


        public static clsLocalDrivingLicenseApplication FindByID(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = -1, LicenseClassID = -1;

            if (clsLocalDrivingLicenseApplicationsData.GetLocalDrivingLicenseApplicationByID(LocalDrivingLicenseApplicationID, ref ApplicationID,
                ref LicenseClassID))
            {
                clsApplication Application = clsApplication.FindBaseApplication(ApplicationID);

                return new clsLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, ApplicationID, Application.ApplicantPersonID,
                    Application.ApplicationTypeID, Application.ApplicationDate, Application.ApplicationStatus, Application.PaidFees,
                    Application.LastStatusDate, Application.CreatedByUserID,LicenseClassID);
               
            }
            else
                return null;
           
        }


        private bool _AddNew()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);
            
            return (this.LocalDrivingLicenseApplicationID != -1);
        }
        private bool _Update()
        {
            return clsLocalDrivingLicenseApplicationsData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID,
                this.ApplicationID, this.LicenseClassID);
        }
        public bool Delete()
        {
            if (clsLocalDrivingLicenseApplicationsData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseApplicationID))
                return base.Delete();
            else
                return false;
        }
        public bool Save()
        {
            base.Mode = (clsApplication.enMode)Mode;

            if (!base.Save())
                return false;

            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _Update();
                    break;
            }
            return false;
        }



        public bool IsThereAnActiveScheduleTest(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationsData.IsThereAnActiveScheduleTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public bool DoesPassTestType(clsTestType.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationsData.DoesPassTestType(this.LocalDrivingLicenseApplicationID,(int) TestTypeID);
        }

        public bool DoesAttendForTestType(clsTestType.enTestType TestTypeID)
        {
            return (TotalTrialsPerTestType(TestTypeID) > 0);
        }
        public byte TotalTrialsPerTestType(clsTestType.enTestType TestTypeID)
        {
            return clsTest.TotalTrialsPerTestType(this.LocalDrivingLicenseApplicationID,TestTypeID);
        }

        public byte TotalPassedTest()
        {
            return clsTest.TotalPassedTest(this.LocalDrivingLicenseApplicationID);
        }
        
        public int IssueDriverLicenseForFirstTime(string Notes,int CreatedByUserID)
        {
            int DriverID = -1;

            clsDriver Driver = clsDriver.FindByPersonID(this.ApplicantPersonID);

            if (Driver == null)
            {
                Driver = new clsDriver();

                Driver.PersonID = this.ApplicantPersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                Driver.CreatedDate = DateTime.Now;

                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                
            }
            else
            {
                DriverID = Driver.DriverID;
            }

            clsLicense DriverLicense = new clsLicense();

            DriverLicense.ApplicationID = this.ApplicationID;
            DriverLicense.DriverID = DriverID;
            DriverLicense.LicenseClassID = this.LicenseClassID;
            DriverLicense.IssueDate = DateTime.Now;
            DriverLicense.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            DriverLicense.Notes = Notes;
            DriverLicense.PaidFees = this.LicenseClassInfo.ClassFees;
            DriverLicense.IsActive = true;
            DriverLicense.CreatedByUserID = CreatedByUserID;
            DriverLicense.IssueReason = clsLicense.enIssueReason.FirstTime;

            if (DriverLicense.Save())
            {
                this.Complete();

                return DriverLicense.LicenseID;
            }

            return -1;

        }

        public int GetActiveLicenseID()
        {
            return clsLicense.GetActiveLicenseIDByPersonID(this.ApplicantPersonID, this.LicenseClassID);
        }
        public bool IsLicenseIssued()
        {
            return (GetActiveLicenseID() != -1);
        }
    }
}
