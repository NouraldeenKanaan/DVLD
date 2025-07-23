using System;
using System.Configuration;

namespace DVLD_DataAccess
{
    public class clsDataAccessSettings
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DVLDConnection"].ConnectionString;
    }
}
