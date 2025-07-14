using System;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsLocalDrivingLicenseApplicationsData
    {
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dtLocalLicenses = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "Select * from LocalDrivingLicenseApplications_View";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtLocalLicenses.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return dtLocalLicenses;
        }
        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int NewLocalDrivingApplicationID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
           ([ApplicationID]
           ,[LicenseClassID])
     VALUES
           (@ApplicationID,@LicenseClassID);
             Select Scope_Identity();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            NewLocalDrivingApplicationID = InsertedID;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return NewLocalDrivingApplicationID;
        }
        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [dbo].[LocalDrivingLicenseApplications]
                             SET [ApplicationID] = @ApplicationID
                                ,[LicenseClassID] = @LicenseClassID
                           WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int RowsAffectd = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "Delete from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                        connection.Open();
                        RowsAffectd = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return (RowsAffectd > 0);
        }
        public static bool GetLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Select * from LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = 
                                                                                @LocalDrivingLicenseApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ApplicationID = (int)reader["ApplicationID"];
                                LicenseClassID = (int)reader["LicenseClassID"];
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
        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsPassed = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT Pass = 1 FROM TestAppointments INNER JOIN Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                             WHERE (TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)
                             AND (TestAppointments.TestTypeID = @TestTypeID)
                             AND (Tests.TestResult = 1);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                            IsPassed = true;
                        else
                            IsPassed = false;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return IsPassed;
        }
        public static bool IsThereAnActiveScheduleTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 Test appointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestType проявляетсяID = @TestTypeID) and isLocked=0
                            ORDER BY TestAppointments.TestAppointmentID desc";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                            IsFound = true;
                        else
                            IsFound = false;
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
