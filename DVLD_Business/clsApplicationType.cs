using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        public enum enMode { AddNew = 0 , Update = 1 };

        public enMode Mode;
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeName { get; set; }
        public decimal ApplicationTypeFees { get; set; }

        public clsApplicationType()
        {
            this.ApplicationTypeID = -1;
            this.ApplicationTypeName = "";
            this.ApplicationTypeFees = 0;

            Mode = enMode.AddNew;
        }
        private clsApplicationType(int ApplicationTypeID,string ApplicationTypeName,decimal ApplicationTypeFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeName = ApplicationTypeName;
            this.ApplicationTypeFees = ApplicationTypeFees;

            Mode = enMode.Update;
        }


        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesData.GetAllApplicationTypes();
        }

        public static clsApplicationType FindByApplicationTypeID(int ApplicationTypeID)
        {
            string ApplicationTypeName = "";
            decimal ApplicationTypeFees = 0;

            if (clsApplicationTypesData.GetApplicationTypeInfoByID(ApplicationTypeID, ref ApplicationTypeName, ref ApplicationTypeFees))
                return new clsApplicationType(ApplicationTypeID, ApplicationTypeName, ApplicationTypeFees);
            else
                return null;
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypesData.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeName, this.ApplicationTypeFees); 
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    break;
                case enMode.Update:
                    return _UpdateApplicationType();
            }
            return false;
        }
    }
}
