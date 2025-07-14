using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsInternationalLicense : clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };

        public enMode Mode;
        public int InternationalLicenseID { get; set; }
        public int DriverID { get; set; }
        public clsDriver DriverInfo;
        public int IssuedUsingLocalDrivingLicenseID { get; set; }
        public clsLicense IssuedUsingLocalDrivingLicenseInfo;
        public DateTime IssuedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }

        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalDrivingLicenseID = -1;
            this.IssuedDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = true;

            Mode = enMode.AddNew;
        }
        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int ApplicantPersonID, int ApplicationTypeID, DateTime ApplicationDate,
            enApplicationStatus ApplicationStatus, decimal PaidFees, DateTime LastStatusDate, int CreatedByUserID, int DriverID, int IssuedUsingLocalDrivingID,
            DateTime IssuedDate, DateTime ExpirationDate, bool IsActive)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            base.ApplicationID = ApplicationID;
            base.ApplicantPersonID = ApplicantPersonID;
            base.ApplicationTypeID = ApplicationTypeID;
            base.ApplicationDate = ApplicationDate;
            base.ApplicationStatus = ApplicationStatus;
            base.PaidFees = PaidFees;
            base.LastStatusDate = LastStatusDate;
            base.CreatedByUserID = CreatedByUserID;
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.FindByID(DriverID);
            this.IssuedUsingLocalDrivingLicenseID = IssuedUsingLocalDrivingID;
            this.IssuedUsingLocalDrivingLicenseInfo = clsLicense.FindByID(IssuedUsingLocalDrivingID);
            this.IssuedDate = IssuedDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);

            Mode = enMode.Update;
        }


        public static DataTable GetInternationalLicenses()
        {
            return clsInternationalLicensesData.GetAllInternationalLicenses();
        }
        public static clsInternationalLicense FindByDriverID(int DriverID)
        {
            int InternationalLicenseID = -1, ApplicationID = -1, IssuedUsingLocalDrivingLicenseID = -1, CreatedByUserID = -1;
            DateTime IssuedDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;

            if (clsInternationalLicensesData.GetInternationalLicenseByDriverID(DriverID, ref InternationalLicenseID, ref ApplicationID,
                ref IssuedUsingLocalDrivingLicenseID, ref IssuedDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                clsApplication BaseApplication = clsApplication.FindBaseApplication(ApplicationID);

                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, BaseApplication.ApplicantPersonID,
                    BaseApplication.ApplicationTypeID, BaseApplication.ApplicationDate, BaseApplication.ApplicationStatus,
                    BaseApplication.PaidFees, BaseApplication.LastStatusDate, CreatedByUserID, DriverID, IssuedUsingLocalDrivingLicenseID,
                    IssuedDate, ExpirationDate, IsActive);

            }
            else
                return null;
            
        }
        public static clsInternationalLicense FindByID(int InternationalLicenseID)
        {
            int DriverID = -1, ApplicationID = -1, IssuedUsingLocalDrivingLicenseID = -1, CreatedByUserID = -1;
            DateTime IssuedDate = DateTime.Now, ExpirationDate = DateTime.Now;
            bool IsActive = false;

            if (clsInternationalLicensesData.GetInternationalLicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID,
                ref IssuedUsingLocalDrivingLicenseID, ref IssuedDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                clsApplication BaseApplication = clsApplication.FindBaseApplication(ApplicationID);

                return new clsInternationalLicense(InternationalLicenseID, ApplicationID, BaseApplication.ApplicantPersonID,
                    BaseApplication.ApplicationTypeID, BaseApplication.ApplicationDate, BaseApplication.ApplicationStatus,
                    BaseApplication.PaidFees, BaseApplication.LastStatusDate, CreatedByUserID, DriverID, IssuedUsingLocalDrivingLicenseID,
                    IssuedDate, ExpirationDate, IsActive);

            }
            else
                return null;

        }
        public static DataTable GetInternationalLicenseByDriverID(int DriverID)
        {
            return clsInternationalLicensesData.InternationalLicenseByDriverID(DriverID);
        }


        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicensesData.NewInternationalLicnse(this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalDrivingLicenseID, this.IssuedDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }
        public bool Save()
        {
            
            base.Mode = (clsApplication.enMode)Mode;

            if (!base.Save())
                return false;
            
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:

                    break;
            }

            return false;
        }
    }
}
