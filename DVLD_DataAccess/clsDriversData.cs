using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDriversData
    {
        public static DataTable GetAllDrivers()
        {
            DataTable dtDrivers = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT Drivers.DriverID, Drivers.PersonID, People.NationalNumber,
People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName,'') + ' ' + People.LastName as FullName,Drivers.CreatedDate,
(select COUNT(Licenses.LicenseID) from Licenses WHERE Licenses.DriverID = Drivers.DriverID) as ActiveLicenses
FROM Drivers INNER JOIN People ON Drivers.PersonID = People.PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtDrivers.Load(reader);
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }     

            return dtDrivers;
        }
        public static int AddNewDriver(int PersonID,int CreatedByUserID,DateTime CreatedDate)
        {
            int NewDriverID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO [dbo].[Drivers]
                                                       ([PersonID]
                                                       ,[CreatedByUserID]
                                                       ,[CreatedDate])
                                                       VALUES
                                                            (@PersonID,@CreatedByUserID,@CreatedDate);
                                                        Select Scope_Identity();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            NewDriverID = InsertedID;
                        }
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return NewDriverID;
        }
        public static bool GetDriverByDriverID(int DriverID,ref int PersonID,ref int CreatedByUserID,ref DateTime CreatedDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from Drivers WHERE DriverID = @DriverID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = (int)reader["PersonID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
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
        public static bool GetDriverByPersonID(int PersonID,ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from Drivers WHERE PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                DriverID = (int)reader["DriverID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
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
    }
}
