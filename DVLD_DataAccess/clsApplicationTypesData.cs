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

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from ApplicationTypes;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dtApplicationTypes.Load(reader);

                reader.Close();
            }
            catch(Exception e)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

            return dtApplicationTypes;
        }
        public static bool GetApplicationTypeInfoByID(int ApplicationTypeID,ref string ApplicationTypeName,ref decimal ApplicationTypeFees)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from ApplicationTypes where ApplicationTypeID = @ID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ApplicationTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    ApplicationTypeName = (string)reader["ApplicationTypeName"];
                    ApplicationTypeFees =  (decimal)reader["ApplicationTypeFees"];
                }
                else
                    IsFound = false;

                reader.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        public static bool UpdateApplicationType(int ApplicationTypeID,string ApplicationTypeName,decimal ApplicationTypeFees)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[ApplicationTypes]
                                                         SET
                                                         [ApplicationTypeName] = @ApplicationTypeName,
                                                         [ApplicationTypeFees] = @ApplicationTypeFees
                                                   WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeName", ApplicationTypeName);
            command.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }
    }
}
