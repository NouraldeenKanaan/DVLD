using System;
using Microsoft.Win32;
using System.IO;

namespace DVLD_Business
{
    public static class clsGlobal
    {
        private static string LoginInfoPath = @"HKEY_CURRENT_USER\SOFTWARE\LoginInfo";

        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string username, string password)
        {
            Registry.SetValue(LoginInfoPath, "Username", username, RegistryValueKind.String);
            Registry.SetValue(LoginInfoPath, "Password", password, RegistryValueKind.String);

            return true;
        }
        public static bool LoadCredential(ref string Username,ref string Password)
        {
            Username = Registry.GetValue(LoginInfoPath, "Username", null) as string;
            Password = Registry.GetValue(LoginInfoPath, "Password", null) as string;

            return true;
        }
    }
}
