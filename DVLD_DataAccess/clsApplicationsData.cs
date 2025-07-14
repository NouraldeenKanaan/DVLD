using System;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsApplicationsData
    {
        public static int AddNewApplication(int ApplicantPersonID,int ApplicationTypeID,DateTime ApplicationDate,short ApplicationStatus,
            decimal PaidFees,DateTime LastStatusDate,int CreatedByUserID)
        {
            int NewApplicationID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO [dbo].[Applications]
                            ([ApplicantPersonID]
                            ,[ApplicationTypeID]
                            ,[ApplicationDate]
                            ,[ApplicationStatus]
                            ,[PaidFees]
                            ,[LastStatusDate]
                            ,[CreatedByUserID])
                       VALUES (@ApplicantPersonID,@ApplicationTypeID,@ApplicationDate,@ApplicationStatus,@PaidFees,@LastStatusDate,@CreatedByUserID);
                        Select Scope_Identity();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                        command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID)) 
                        {
                            NewApplicationID = InsertedID;
                        } 
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return NewApplicationID;
        }
        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, int ApplicationTypeID, DateTime ApplicationDate, short ApplicationStatus,
            decimal PaidFees, DateTime LastStatusDate, int CreatedByUserID)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {

                    connection.Open();

                    string query = @"UPDATE [dbo].[Applications]
                                          SET [ApplicantPersonID] = @ApplicantPersonID
                                             ,[ApplicationTypeID] = @ApplicationTypeID
                                             ,[ApplicationDate] = @ApplicationDate
                                             ,[ApplicationStatus] = @ApplicationStatus
                                             ,[PaidFees] = @PaidFees
                                             ,[LastStatusDate] = @LastStatusDate
                                             ,[CreatedByUserID] = @CreatedByUserID
                                        WHERE ApplicationID = @ApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
                        command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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
        public static bool DeleteApplication(int ApplicationID)
        {
            int RowsAffectd = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Delete From Applications Where ApplicationID = @ApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        public static bool GetApplicationInfoByID(int ApplicationID, ref int ApplicantPersonID, ref int ApplicationTypeID, ref DateTime ApplicationDate,
           ref short ApplicationStatus, ref decimal PaidFees, ref DateTime LastStatusDate, ref int CreatedByUserID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Applications Where ApplicationID = @ApplicationID ;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ApplicantPersonID = (int)reader["ApplicantPersonID"];
                                ApplicationTypeID = (int)reader["ApplicationTypeID"];
                                ApplicationDate = (DateTime)reader["ApplicationDate"];
                                ApplicationStatus = (byte)reader["ApplicationStatus"];
                                PaidFees = (decimal)reader["PaidFees"];
                                LastStatusDate = (DateTime)reader["LastStatusDate"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
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
        public static bool UpdateStatus(int ApplicationID,short NewApplicationStatus)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Update Applications SET [ApplicationStatus] = @NewApplicationStatus,
                                                     [LastStatusDate]    = @LastStatusDate
                                                 where ApplicationID = @ApplicationID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewApplicationStatus", NewApplicationStatus);
                        command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        public static int GetActiveApplicationIDForLicenseClass(int ApplicantPersonID,int ApplicationTypeID,int LicenseClassID)
        {
            int ApplicationID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT Applications.ApplicationID FROM Applications INNER JOIN LocalDrivingLicenseApplications 
                             ON 
                             Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             WHERE ApplicantPersonID = @ApplicantPersonID 
                             and LicenseClassID = @LicenseClassID  
                             and ApplicationTypeID = @ApplicationTypeID
                             and ApplicationStatus = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            ApplicationID = InsertedID;
                        }
                    }                  
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return ApplicationID;
        }
    }
}
