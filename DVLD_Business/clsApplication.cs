using DVLD_DataAccess;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace DVLD_Business
{
    public class clsApplication
    {
        public enum enMode { AddNew = 0 , Update = 1};
        public enum enApplicationType { NewDrivingLicense = 1 , RenewDrivingLicense = 2 , ReplaceLostDrivingLicense = 3,
        ReplaceDamagedDrivingLicense = 4 , ReleaseDetainedDrivingLicense = 5 , NewInternationalDrivingLicense = 6 , RetakeTest = 7};
        public enum enApplicationStatus { New = 1 , Cancelled = 2 , Completed = 3};

        public enMode Mode = enMode.AddNew;
        
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }

        public clsPerson ApplicantPersonInfo;
        public string ApplicantFullName { get { return clsPerson.FindByID(ApplicantPersonID).FullName; } }
        public int ApplicationTypeID { get; set; }

        public clsApplicationType ApplicationTypeInfo;
        public DateTime ApplicationDate { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public string StatusText
        {
            get 
            {
                switch(ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }
        }
        public decimal PaidFees { get; set; }
        public DateTime LastStatusDate { get; set; }
        public int CreatedByUserID { get; set; }

        public clsUser CreatedByUserInfo;



        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationTypeID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationStatus = enApplicationStatus.New;
            this.PaidFees = 0;
            this.LastStatusDate = DateTime.Now;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }
        private clsApplication(int ApplicationID, int ApplicantPersonID, int ApplicationTypeID, DateTime ApplicationDate, enApplicationStatus ApplicationStatus,
            decimal PaidFees, DateTime LastStatusDate, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicantPersonInfo = clsPerson.FindByID(ApplicantPersonID);
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.FindByApplicationTypeID(ApplicationTypeID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationStatus = ApplicationStatus;
            this.PaidFees = PaidFees;
            this.LastStatusDate = LastStatusDate;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);

            Mode = enMode.Update;
        }



        public static clsApplication FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            short ApplicationStatus = 0;
            decimal PaidFees = 0;

            if (clsApplicationsData.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationTypeID, ref ApplicationDate
                , ref ApplicationStatus, ref PaidFees, ref LastStatusDate, ref CreatedByUserID))
                return new clsApplication(ApplicationID, ApplicantPersonID,ApplicationTypeID,ApplicationDate, 
                    (enApplicationStatus)ApplicationStatus, PaidFees, LastStatusDate, CreatedByUserID);
            else
                return null;
        }


        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationsData.AddNewApplication(this.ApplicantPersonID, this.ApplicationTypeID, this.ApplicationDate,
                (byte)this.ApplicationStatus, this.PaidFees, this.LastStatusDate, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }
        private bool _UpdateApplication()
        {
            return clsApplicationsData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationTypeID, this.ApplicationDate,
                (byte)this.ApplicationStatus, this.PaidFees, this.LastStatusDate, this.CreatedByUserID);
        }
        public bool Delete()
        {
            return clsApplicationsData.DeleteApplication(this.ApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateApplication();
            }

            return false;
        }


        public static int GetActiveApplicationIDForLicenseClass(int PersonID,clsApplication.enApplicationType ApplicationTypeID,int LicenseClassID)
        {
            return clsApplicationsData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }


        public bool Cancel()
        {
            return clsApplicationsData.UpdateStatus(ApplicationID,(short)enApplicationStatus.Cancelled);
        }
        public bool Complete()
        {
            return clsApplicationsData.UpdateStatus(ApplicationID, (short)enApplicationStatus.Completed);
        }
    }
}
