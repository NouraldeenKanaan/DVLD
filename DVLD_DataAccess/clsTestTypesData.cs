using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestTypesData
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dtTestTypes = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM TestTypes;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtTestTypes.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return dtTestTypes;
        }
        public static bool GetTestTypeInfoByID(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "select * from TestTypes where TestTypeID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", TestTypeID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                TestTypeTitle = (string)reader["TestTypeTitle"];
                                TestTypeDescription = (string)reader["TestTypeDescription"];
                                TestTypeFees = (decimal)reader["TestTypeFees"];
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
        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [dbo].[TestTypes]
                                                 SET [TestTypeTitle] = @TestTypeTitle
                                                    ,[TestTypeFees] = @TestTypeFees
                                                    ,[TestTypeDescription] = @TestTypeDescription
                                               WHERE TestTypeID = @TestTypeID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
                        command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
                        command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

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
    }
}
