using System;
using System.Linq;
using System.Text;
using System.IO;

namespace DVLD_Business
{
    public static class clsGlobal
    {
        private static string FilePath = "E:\\Git\\DVLD\\Login\\UsersInfo.txt";

        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                File.WriteAllText(FilePath,string.Empty);
                return false;
            }
            else
                File.WriteAllText(FilePath,$"{username}|{password}");

            return true;
        }
        public static bool LoadCredential(ref string Username,ref string Password)
        {
            if (File.Exists(FilePath))
            {
                string FullText = File.ReadAllText(FilePath);

                if (FullText.Length > 1)
                {
                    string[] Data = FullText.Split('|');
                    Username = Data[0];
                    Password = Data[1];
                    return true;
                }
                else
                {
                    Username = "";
                    Password = "";
                }
            }
            return false;
        }
    }
}
