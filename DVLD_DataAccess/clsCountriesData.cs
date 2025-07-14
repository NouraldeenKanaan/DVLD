using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsCountriesData
    {
        public static DataTable GetAllCountries()
        {
            DataTable dtCountries = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from Countries";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtCountries.Load(reader);
                        }
                    }                   
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return dtCountries;
        }
        public static bool GetCountryInfoByID(int CountryID,ref string CountryName)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Countries where CountryID = @CountryID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", CountryID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                CountryName = (string)reader["CountryName"];
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
        public static bool GetCountryInfoByName(string CountryName,ref int CountryID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select * from Countries where CountryName = @CountryName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryName", CountryName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                CountryID = (int)reader["CountryID"];
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
    }
}
