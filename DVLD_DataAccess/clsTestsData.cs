using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestsData
    {
        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int TestID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO [dbo].[Tests]
                                    ([TestAppointmentID]
                                    ,[TestResult]
                                    ,[Notes]
                                    ,[CreatedByUserID])
                                  VALUES
                                    (@TestAppointmentID,@TestResult,@Notes,@CreatedByUserID);
                                  Select Scope_Identity();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestResult", TestResult);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            TestID = InsertedID;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return TestID;
        }
        public static byte TotalTrialsPerTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            byte Trials = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT COUNT(TestID) as TotalTrials FROM Tests INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                                                     WHERE TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                                     AND TestAppointments.TestTypeID = @TestTypeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int Total))
                        {
                            Trials = (byte)Total;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return Trials;
        }
        public static byte TotalPassedTests(int LocalDrivingLicenseApplicationID)
        {
            byte TotalTests = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT COUNT(TestTypeID) as TotalPassedTests FROM TestAppointments INNER JOIN Tests ON 
                                    TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                    WHERE Tests.TestResult = 1
                                    AND TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int Total))
                            TotalTests = (byte)Total;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return TotalTests;
        }
    }
}
