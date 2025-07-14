using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0 , Update = 1};
        public enMode Mode;

        public int UserID { get; set; }
        public int PersonID { get; set; }

        public clsPerson PersonInfo;
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = true;
            
            Mode = enMode.AddNew;
        }
        private clsUser(int UserID,int PersonID,string Username,string Password,bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.FindByID(PersonID);
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }


        public static DataTable GetAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }
        public static clsUser FindByUsernameAndPassword(string Username,string Password)
        {
            int PersonID = -1, UserID = -1;
            bool IsActive = false;

            if (clsUsersData.GetUserInfoByUsernameAndPassword(Username, Password, ref UserID, ref PersonID, ref IsActive))
                return new clsUser(UserID, PersonID, Username, Password, IsActive);
            else
                return null;
        }
        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string Username = "", Password = "";
            bool IsActive = false;

            if (clsUsersData.GetUserInfoByUserID(UserID, ref PersonID, ref Username, ref Password, ref IsActive))
                return new clsUser(UserID, PersonID, Username, Password, IsActive);
            else
                return null;
        }


        public static bool IsUserExistForPersonID(int PersonID)
        {
            return clsUsersData.IsUserExistForPersonID(PersonID);
        }
        public static bool IsUserExist(string Username)
        {
            return clsUsersData.IsUserExists(Username);
        }


        private bool _AddNewUser()
        {
            this.UserID = clsUsersData.AddNewUser(this.PersonID, this.Username, this.Password, this.IsActive);

            return (this.UserID != -1);

        }
        private bool _UpdateUser()
        {
            return clsUsersData.UpdateUser(this.UserID,this.PersonID, this.Username, this.Password, this.IsActive); 
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateUser();
                    break;
            }

            return false;
        }
        public static bool DeleteUser(int UserID)
        {
            return clsUsersData.DeleteUser(UserID);
        }

        public bool ChangePassword(string NewPassword)
        {
            return clsUsersData.ChangePassword(this.UserID,NewPassword);
        }
    }
}
