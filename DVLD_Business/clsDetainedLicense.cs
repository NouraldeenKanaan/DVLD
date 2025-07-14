using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsDetainedLicense
    {
        public enum enMode { AddNew = 0 , Update = 1};

        public enMode Mode;
        public int DetainID { get; set; }
        public int LicenseID { get; set; }

        public clsLicense LicenseInfo;
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CreatedByUserID { get; set; }

        public clsUser CreatedByUserInfo; 
        public int ReleasedByUserID { get; set; }

        public clsUser ReleasedByUserInfo;
        public int ReleaseApplicationID { get; set; }

        public clsApplication ReleaseApplicationInfo;


        public clsDetainedLicense()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.Now;
            this.CreatedByUserID = -1;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;

            Mode = enMode.AddNew;
        }
        private clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, bool IsReleased, DateTime ReleaseDate,
            int CreatedByUserID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.LicenseInfo = clsLicense.FindByID(LicenseID);
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleasedByUserInfo = clsUser.FindByUserID(ReleasedByUserID);
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.ReleaseApplicationInfo = clsApplication.FindBaseApplication(ReleaseApplicationID);

            Mode = enMode.Update;
        }


        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicensesData.GetAllDetainedLicenses();
        }
        public static clsDetainedLicense FindByLicenseID(int LicenseID)
        {
            int DetainID = -1, ReleasedByUserID = -1, CreatedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now;
            decimal FineFees = 0;
            bool IsReleased = false;

            if (clsDetainedLicensesData.FindByLicenseID(LicenseID, ref DetainID, ref DetainDate, ref FineFees, ref IsReleased, ref ReleaseDate,
                ref CreatedByUserID, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, IsReleased, ReleaseDate, CreatedByUserID, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }
        public static clsDetainedLicense FindByDetainID(int DetainID)
        {
            int LicenseID = -1, ReleasedByUserID = -1, CreatedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.Now, ReleaseDate = DateTime.Now;
            decimal FineFees = 0;
            bool IsReleased = false;

            if (clsDetainedLicensesData.FindByDetainID(DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref IsReleased, ref ReleaseDate,
                ref CreatedByUserID, ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, IsReleased, ReleaseDate, CreatedByUserID, ReleasedByUserID, ReleaseApplicationID);
            else
                return null;
        }


        private bool _AddNewDetain()
        {
            this.DetainID = clsDetainedLicensesData.AddNewDetain(this.LicenseID, this.DetainDate, this.FineFees, this.IsReleased, this.ReleaseDate,
                this.CreatedByUserID, this.ReleasedByUserID, this.ReleaseApplicationID);

            return (this.DetainID != -1);
        }
        private bool _UpdateDetained()
        {
            return clsDetainedLicensesData.UpdateDetained(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.IsReleased,
                this.ReleaseDate, this.CreatedByUserID, this.ReleasedByUserID, this.ReleaseApplicationID);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetain())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateDetained();
                    break;
            }

            return false;
        }
    }
}
