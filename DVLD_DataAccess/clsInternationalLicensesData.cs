using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsInternationalLicensesData
    {
        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dtInternationalLicenses = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
                             FROM InternationalLicenses;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtInternationalLicenses.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return dtInternationalLicenses;
        }
        public static int NewInternationalLicnse(int ApplicationID,int DriverID,int IssuedUsingLocalLicenseID,DateTime IssueDate,
            DateTime ExpirationDate,bool IsActive,int CreatedByUserID)
        {
            int NewInternationaLicenseID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO [dbo].[InternationalLicenses]
           ([ApplicationID]
           ,[DriverID]
           ,[IssuedUsingLocalLicenseID]
           ,[IssueDate]
           ,[ExpirationDate]
           ,[IsActive]
           ,[CreatedByUserID])
     VALUES
           (@ApplicationID,@DriverID,@IssuedUsingLocalLicenseID,@IssueDate,@ExpirationDate,@IsActive,@CreatedByUserID);
		   select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            NewInternationaLicenseID = InsertedID;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return NewInternationaLicenseID;
        }
        public static bool GetInternationalLicenseByID(int InternationalLicenseID,ref int ApplicationID,ref int DriverID,ref int IssuedUsingLocalLicenseID,
           ref DateTime IssueDate,ref DateTime ExpirationDate,ref bool IsActive,ref int CreatedByUserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "Select * from InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ApplicationID = (int)reader["ApplicationID"];
                                DriverID = (int)reader["DriverID"];
                                IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                                IssueDate = (DateTime)reader["IssueDate"];
                                ExpirationDate = (DateTime)reader["ExpirationDate"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
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
        public static bool GetInternationalLicenseByDriverID(int DriverID,ref int InternationalLicenseID, ref int ApplicationID, ref int IssuedUsingLocalLicenseID,
                   ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "Select * from InternationalLicenses WHERE DriverID = @DriverID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                InternationalLicenseID = (int)reader["InternationalLicenseID"];
                                ApplicationID = (int)reader["ApplicationID"];
                                IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                                IssueDate = (DateTime)reader["IssueDate"];
                                ExpirationDate = (DateTime)reader["ExpirationDate"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
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
        public static DataTable InternationalLicenseByDriverID(int DriverID)
        {
            DataTable dtInternationalLicense = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select InternationalLicenseID,ApplicationID,
                        IssuedUsingLocalLicenseID , IssueDate,ExpirationDate,IsActive  from InternationalLicenses where DriverID = @DriverID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtInternationalLicense.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
           
            return dtInternationalLicense;
        }
    }
}
