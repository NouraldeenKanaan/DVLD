using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DVLD_DataAccess
{
    public class clsDetainedLicensesData
    {
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dtDetainedLicenses = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from DetainedLicenses_View order by DetainDate desc";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtDetainedLicenses.Load(reader);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            } 

            return dtDetainedLicenses;
        }
        public static int AddNewDetain(int LicenseID,DateTime DetainDate, decimal FineFees, bool IsReleased,
             DateTime ReleaseDate,  int CreatedByUserID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int DetainID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO [dbo].[DetainedLicenses]
           ([LicenseID]
           ,[DetainDate]
           ,[FineFees]
           ,[IsReleased]
           ,[ReleaseDate]
           ,[CreatedByUserID]
           ,[ReleasedByUserID]
           ,[ReleaseApplicationID])
     VALUES
           (@LicenseID,@DetainDate,@FineFees,@IsReleased,@ReleaseDate,@CreatedByUserID
           ,@ReleasedByUserID,@ReleaseApplicationID);
		   select SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
                        command.Parameters.AddWithValue("@FineFees", FineFees);
                        command.Parameters.AddWithValue("@IsReleased", IsReleased);
                        command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
                        command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            DetainID = InsertedID;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }       

            return DetainID;
        }
        public static bool UpdateDetained(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, bool IsReleased,
             DateTime ReleaseDate, int CreatedByUserID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"UPDATE [dbo].[DetainedLicenses]
                             SET [LicenseID] = @LicenseID
                                ,[DetainDate] = @DetainDate
                                ,[FineFees] = @FineFees
                                ,[IsReleased] = @IsReleased
                                ,[ReleaseDate] = @ReleaseDate
                                ,[CreatedByUserID] = @CreatedByUserID
                                ,[ReleasedByUserID] = @ReleasedByUserID
                                ,[ReleaseApplicationID] = @ReleaseApplicationID
                           WHERE DetainID = @DetainID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@DetainID", DetainID);
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
                        command.Parameters.AddWithValue("@FineFees", FineFees);
                        command.Parameters.AddWithValue("@IsReleased", IsReleased);
                        command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                        command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

                        RowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return (RowsAffected > 0);
        }
        public static bool FindByLicenseID(int LicenseID,ref int DetainID,ref DateTime DetainDate,ref decimal FineFees,ref bool IsReleased,
            ref DateTime ReleaseDate,ref int CreatedByUserID,ref int ReleasedByUserID,ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from DetainedLicenses Where LicenseID = @LicenseID order by DetainDate desc";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                DetainID = (int)reader["DetainID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = (decimal)reader["FineFees"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] == DBNull.Value)
                                    ReleaseDate = DateTime.Now;
                                else
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];

                                CreatedByUserID = (int)reader["CreatedByUserID"];

                                if (reader["ReleasedByUserID"] == DBNull.Value)
                                    ReleasedByUserID = -1;
                                else
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];

                                if (reader["ReleaseApplicationID"] == DBNull.Value)
                                    ReleaseApplicationID = -1;
                                else
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
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
        public static bool FindByDetainID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref decimal FineFees, ref bool IsReleased,
            ref DateTime ReleaseDate, ref int CreatedByUserID, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from DetainedLicenses Where DetainID = @DetainID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DetainID", DetainID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                LicenseID = (int)reader["LicenseID"];
                                DetainDate = (DateTime)reader["DetainDate"];
                                FineFees = (decimal)reader["FineFees"];
                                IsReleased = (bool)reader["IsReleased"];

                                if (reader["ReleaseDate"] == DBNull.Value)
                                    ReleaseDate = DateTime.Now;
                                else
                                    ReleaseDate = (DateTime)reader["ReleaseDate"];

                                CreatedByUserID = (int)reader["CreatedByUserID"];

                                if (reader["ReleasedByUserID"] == DBNull.Value)
                                    ReleasedByUserID = -1;
                                else
                                    ReleasedByUserID = (int)reader["ReleasedByUserID"];

                                if (reader["ReleaseApplicationID"] == DBNull.Value)
                                    ReleaseApplicationID = -1;
                                else
                                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];
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
    }
}
