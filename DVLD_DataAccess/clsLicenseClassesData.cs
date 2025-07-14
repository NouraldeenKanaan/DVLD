using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsLicenseClassesData
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dtLicenseClasses = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "select * from LicenseClasses;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtLicenseClasses.Load(reader);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return dtLicenseClasses;
        }
        public static bool GetLicenseClassInfoByID(int LicenseClassID,ref string ClassName,ref string ClassDescription,ref byte MinimumAllowedAge,
            ref byte DefaultValidityLength,ref decimal ClassFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"select * from LicenseClasses Where LicenseClassID = @LicenseClassID ;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ClassName = (string)reader["ClassName"];
                                ClassDescription = (string)reader["ClassDescription"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = (decimal)reader["ClassFees"];
                            }
                            else
                                IsFound = false;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return IsFound;
        }
        public static bool GetLicenseClassInfoByName(string ClassName,ref int LicenseClassID, ref string ClassDescription, ref byte MinimumAllowedAge,
            ref byte DefaultValidityLength, ref decimal ClassFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"select * from LicenseClasses Where ClassName = @ClassName ;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassName", ClassName);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                LicenseClassID = (int)reader["LicenseClassID"];
                                ClassDescription = (string)reader["ClassDescription"];
                                MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                                DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                                ClassFees = (decimal)reader["ClassFees"];
                            }
                            else
                                IsFound = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
  
            return IsFound;
        }
    }
}
