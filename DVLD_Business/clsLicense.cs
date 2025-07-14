using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsLicense
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enIssueReason { FirstTime = 1 , Renew = 2 , DamagedReplcement = 3 , LostReplacement = 4 }

        public enMode Mode;
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }

        public clsApplication ApplicationInfo;
        public int DriverID { get; set; }

        public clsDriver DriverInfo;
        public int LicenseClassID { get; set; }

        public clsLicenseClass LicenseClassInfo;
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsUser CreatedByUserInfo;
        public enIssueReason IssueReason { get; set; }
        public string IssueReasonText { get { return GetIssueReasonAsText(this.IssueReason); } }
        public bool IsDetained { get { return _IsDetained(); } }

        
        public string GetIssueReasonAsText(enIssueReason IssueReason)
        {
            switch(IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplcement:
                    return "Damaged Replacement";
                case enIssueReason.LostReplacement:
                    return "Lost Replacement";
            }
            return "";
        }


        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            this.IssueReason = enIssueReason.FirstTime;

            Mode = enMode.AddNew;
        }
        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate
            , string Notes, decimal PaidFees, bool IsActive,int CreatedByUserID, enIssueReason IssueReason)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.ApplicationInfo = clsApplication.FindBaseApplication(ApplicationID);
            this.DriverID = DriverID;
            this.DriverInfo = clsDriver.FindByID(DriverID);
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            this.IssueReason = IssueReason;

            Mode = enMode.Update;
        }

        public static clsLicense FindByID(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0;
            bool IsActive = false;
            byte IssueReason = 0;

            if (clsLicensesData.GetLicenseByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate,
                ref Notes, ref PaidFees, ref IsActive, ref CreatedByUserID, ref IssueReason))
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, CreatedByUserID, (enIssueReason)IssueReason);
            else
                return null;
        }
        public static DataTable GetDriverLicenses(int DriverID)
        {
            return clsLicensesData.GetDriverLicenses(DriverID);
        }


        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicensesData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate, this.ExpirationDate,
                this.Notes, this.PaidFees, this.IsActive, this.CreatedByUserID, (byte)this.IssueReason);

            return (this.LicenseID != -1);
        }
        private bool _UpdateLicense()
        {
            return clsLicensesData.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate,
                this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, this.CreatedByUserID, (byte)this.IssueReason);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if(_AddNewLicense())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateLicense();
                    break;
            }

            return false;
        }

        private bool _DeActivateLicense()
        {
            this.IsActive = false;

            if (this.Save())
                return true;

            return false;
        }
        public clsLicense RenewLicense(string Notes,int CreatedByUserID)
        {
            clsApplication RenewApplicaton = new clsApplication();

            RenewApplicaton.ApplicantPersonID = this.DriverInfo.PersonID;
            RenewApplicaton.ApplicationTypeID = (int)clsApplication.enApplicationType.RenewDrivingLicense;
            RenewApplicaton.ApplicationDate = DateTime.Now;

            RenewApplicaton.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            RenewApplicaton.PaidFees = Convert.ToDecimal(clsApplicationType.FindByApplicationTypeID(
                (int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationTypeFees);

            RenewApplicaton.LastStatusDate = DateTime.Now;
            RenewApplicaton.CreatedByUserID = CreatedByUserID;

            if (!RenewApplicaton.Save())
                return null ;

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = RenewApplicaton.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(this.LicenseClassID).DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = this.LicenseClassInfo.ClassFees + RenewApplicaton.PaidFees; 
            NewLicense.IsActive = true;
            NewLicense.CreatedByUserID = CreatedByUserID;
            NewLicense.IssueReason = clsLicense.enIssueReason.Renew;

            _DeActivateLicense();

            if (NewLicense.Save())
                return NewLicense;

            return null;
        }
        public clsLicense Replace(enIssueReason IssueReason,int CreatedByUserID)
        {
            clsApplication NewApplication = new clsApplication();

            NewApplication.ApplicantPersonID = this.DriverInfo.PersonID;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            NewApplication.LastStatusDate = DateTime.Now;
            NewApplication.CreatedByUserID = CreatedByUserID;

            if (IssueReason == enIssueReason.DamagedReplcement)
                NewApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense;           
            else
                NewApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;

            NewApplication.PaidFees = clsApplicationType.FindByApplicationTypeID(NewApplication.ApplicationTypeID).ApplicationTypeFees;
            

            if (!NewApplication.Save())
                return null;

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = NewApplication.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = this.ExpirationDate;
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = 0;
            NewLicense.IsActive = true;
            NewLicense.CreatedByUserID = CreatedByUserID;
            NewLicense.IssueReason = IssueReason;

            if (!NewLicense.Save())
                return null;

            _DeActivateLicense();

            return NewLicense;
        }
        public int Detain(decimal FineFees,int CreatedByUserID)
        {
            clsDetainedLicense Detain = new clsDetainedLicense();

            Detain.LicenseID = this.LicenseID;
            Detain.DetainDate = DateTime.Now;
            Detain.FineFees = FineFees;
            Detain.IsReleased = false;
            Detain.CreatedByUserID = CreatedByUserID;

            if (!Detain.Save())
                return -1;

            _DeActivateLicense();
            
            return Detain.DetainID;
        }
        public clsDetainedLicense Release(int ReleaseByUserID)
        {
            clsApplication ReleaseApplication = new clsApplication();
            ReleaseApplication.ApplicantPersonID = this.DriverInfo.PersonID;
            ReleaseApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense;
            ReleaseApplication.ApplicationDate = DateTime.Now;
            ReleaseApplication.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            ReleaseApplication.PaidFees = clsApplicationType.FindByApplicationTypeID((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense).ApplicationTypeFees;
            ReleaseApplication.LastStatusDate = DateTime.Now;
            ReleaseApplication.CreatedByUserID = ReleaseByUserID;

            if (!ReleaseApplication.Save())
                return null;

            clsDetainedLicense ReleaseLicense = clsDetainedLicense.FindByLicenseID(this.LicenseID);

            ReleaseLicense.IsReleased = true;
            ReleaseLicense.ReleaseDate = DateTime.Now;
            ReleaseLicense.ReleasedByUserID = ReleaseByUserID;
            ReleaseLicense.ReleaseApplicationID = ReleaseApplication.ApplicationID;

            if (!ReleaseLicense.Save())
                return null;

            this.IsActive = true;

            if (this.Save())
                return ReleaseLicense;

            return null;
        }

        private bool _IsDetained()
        {
            return clsLicensesData.IsDetained(this.LicenseID);
        }

        public static bool IsLicenseExistByPersonID(int PersonID, int LicenseClassID)
        {
            return (GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1);
        }
        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            return clsLicensesData.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);
        }
    }
}
