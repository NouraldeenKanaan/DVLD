using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsLicensesData
    {
        public static bool GetLicenseByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate,
             ref DateTime ExpirationDate, ref string Notes, ref decimal PaidFees, ref bool IsActive, ref int CreatedByUserID, ref byte IssueReason)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "Select * from Licenses WHERE LicenseID = @LicenseID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ApplicationID = (int)reader["ApplicationID"];
                                DriverID = (int)reader["DriverID"];
                                LicenseClassID = (int)reader["LicenseClassID"];
                                IssueDate = (DateTime)reader["IssueDate"];
                                ExpirationDate = (DateTime)reader["ExpirationDate"];
                                Notes = (string)reader["Notes"];
                                PaidFees = (decimal)reader["PaidFees"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IssueReason = (byte)reader["IssueReason"];
                            }
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
        public static int AddNewLicense(int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes,
            decimal PaidFees, bool IsActive, int CreatedByUserID, byte IssueReason)
        {
            int NewLicenseID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO [dbo].[Licenses]
           ([ApplicationID]
           ,[DriverID]
           ,[LicenseClassID]
           ,[IssueDate]
           ,[ExpirationDate]
           ,[Notes]
           ,[PaidFees]
           ,[IsActive]
           ,[CreatedByUserID]
           ,[IssueReason])
     VALUES
           (@ApplicationID,@DriverID,@LicenseClassID,@IssueDate,@ExpirationDate,@Notes,@PaidFees
           ,@IsActive,@CreatedByUserID,@IssueReason);
           Select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@Notes", Notes);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IssueReason", IssueReason);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            NewLicenseID = InsertedID;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return NewLicenseID;
        }
        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes,
            decimal PaidFees, bool IsActive, int CreatedByUserID, byte IssueReason)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [dbo].[Licenses]
   SET [ApplicationID] = @ApplicationID
      ,[DriverID] = @DriverID
      ,[LicenseClassID] = @LicenseClassID
      ,[IssueDate] = @IssueDate
      ,[ExpirationDate] = @ExpirationDate
      ,[Notes] = @Notes
      ,[PaidFees] = @PaidFees
      ,[IsActive] = @IsActive
      ,[CreatedByUserID] = @CreatedByUserID
      ,[IssueReason] = @IssueReason
 WHERE LicenseID = @LicenseID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@Notes", Notes);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IssueReason", IssueReason);

                        connection.Open();
                        RowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return (RowsAffected > 0);
        }
        public static DataTable GetDriverLicenses(int DriverID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT        Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
FROM            Licenses INNER JOIN
                         LicenseClasses ON Licenses.LicenseClassID = LicenseClasses.LicenseClassID
Where DriverID = @DriverID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return dt;
        }
        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            int ActiveLicenseID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT Licenses.LicenseID FROM Drivers INNER JOIN Licenses ON Drivers.DriverID = Licenses.DriverID
                                        Where Drivers.PersonID = @PersonID
                                        AND Licenses.LicenseClassID = @LicenseClassID
                                        AND Licenses.IsActive = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            ActiveLicenseID = InsertedID;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return ActiveLicenseID;
        }
        public static bool IsDetained(int LicenseID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Select Found = 1 From DetainedLicenses inner join Licenses On
                             DetainedLicenses.LicenseID = Licenses.LicenseID Where DetainedLicenses.LicenseID = @LicenseID
                             AND Licenses.IsActive = 0";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                            IsFound = true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return IsFound;
        }
    }
}
