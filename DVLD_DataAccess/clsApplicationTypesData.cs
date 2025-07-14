using System;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsApplicationTypesData
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dtApplicationTypes = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from ApplicationTypes;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtApplicationTypes.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return dtApplicationTypes;
        }
        public static bool GetApplicationTypeInfoByID(int ApplicationTypeID,ref string ApplicationTypeName,ref decimal ApplicationTypeFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from ApplicationTypes where ApplicationTypeID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ApplicationTypeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ApplicationTypeName = (string)reader["ApplicationTypeName"];
                                ApplicationTypeFees = (decimal)reader["ApplicationTypeFees"];
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
        public static bool UpdateApplicationType(int ApplicationTypeID,string ApplicationTypeName,decimal ApplicationTypeFees)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"UPDATE [dbo].[ApplicationTypes]
                                                         SET
                                                         [ApplicationTypeName] = @ApplicationTypeName,
                                                         [ApplicationTypeFees] = @ApplicationTypeFees
                                                   WHERE ApplicationTypeID = @ApplicationTypeID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationTypeName", ApplicationTypeName);
                        command.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);

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
    }
}
