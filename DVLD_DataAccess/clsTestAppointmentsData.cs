using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentsData
    {
        public static int AddNewTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID, DateTime AppointmentDate, decimal PaidFees,
            int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int NewAppointmentID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO [dbo].[TestAppointments]
                            ([LocalDrivingLicenseApplicationID]
                            ,[TestTypeID]
                            ,[AppointmentDate]
                            ,[PaidFees]
                            ,[CreatedByUserID]
                            ,[IsLocked]
                            ,[RetakeTestApplicationID])
                            VALUES
                            (@LocalDrivingLicenseApplicationID,@TestTypeID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestApplicationID);
                            SELECT Scope_Identity();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);

                        if (RetakeTestApplicationID == -1)
                            command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            NewAppointmentID = InsertedID;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return NewAppointmentID;
        }
        public static bool UpdateTestAppointment(int TestAppointmentID, int LocalDrivingLicenseApplicationID, int TestTypeID, DateTime AppointmentDate,
            decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [dbo].[TestAppointments]
                                          SET [LocalDrivingLicenseApplicationID] = @LocalDrivingLicenseApplicationID
                                             ,[TestTypeID] = @TestTypeID
                                             ,[AppointmentDate] = @AppointmentDate
                                             ,[PaidFees] = @PaidFees
                                             ,[CreatedByUserID] = @CreatedByUserID
                                             ,[IsLocked] = @IsLocked
                                             ,[RetakeTestApplicationID] = @RetakeTestApplicationID
                                        WHERE TestAppointmentID = @TestAppointmentID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);

                        if (RetakeTestApplicationID == -1)
                            command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

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
        public static bool GetTestAppointmentInfoByID(int TestAppointmentID, ref int LocalDrivingLicenseApplicationID, ref int TestTypeID,
            ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "Select * from TestAppointments Where TestAppointmentID = @TestAppointmentID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                                TestTypeID = (int)reader["TestTypeID"];
                                AppointmentDate = (DateTime)reader["AppointmentDate"];
                                PaidFees = (decimal)reader["PaidFees"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                IsLocked = (bool)reader["IsLocked"];

                                if (reader["RetakeTestApplicationID"] == DBNull.Value)
                                    RetakeTestApplicationID = -1;
                                else
                                    RetakeTestApplicationID = (int)reader["RetakeTestApplicationID"];
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
        public static DataTable GetApplicationTestAppointmentPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"select TestAppointmentID,AppointmentDate,PaidFees,IsLocked from TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                             AND TestTypeID = @TestTypeID order by TestAppointmentID desc";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
    }    
}
