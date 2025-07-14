using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsPeopleData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string NationNumber, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
             ref DateTime DateOfBirth, ref byte Gender, ref string Phone, ref string Email, ref string Address, ref int NationalityID, ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM PEOPLE WHERE PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                NationNumber = (string)reader["NationalNumber"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                if (reader["ThirdName"] == DBNull.Value)
                                    ThirdName = "";
                                else
                                    ThirdName = (string)reader["ThirdName"];

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Phone = (string)reader["PhoneNumber"];

                                if (reader["Email"] == DBNull.Value)
                                    Email = "";
                                else
                                    Email = (string)reader["Email"];

                                Address = (string)reader["Address"];
                                NationalityID = (int)reader["NationalityID"];

                                if (reader["ImagePath"] == DBNull.Value)
                                    ImagePath = "";
                                else
                                    ImagePath = (string)reader["ImagePath"];

                                IsFound = true;
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
        public static bool GetPersonInfoByNationalNumber(string NationalNumber, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
             ref DateTime DateOfBirth, ref byte Gender, ref string Phone, ref string Email, ref string Address, ref int NationalityID, ref string ImagePath)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM PEOPLE WHERE NationalNumber = @NationalNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];

                                if (reader["ThirdName"] == DBNull.Value)
                                    ThirdName = "";
                                else
                                    ThirdName = (string)reader["ThirdName"];

                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gender = (byte)reader["Gender"];
                                Phone = (string)reader["PhoneNumber"];

                                if (reader["Email"] == DBNull.Value)
                                    Email = "";
                                else
                                    Email = (string)reader["Email"];

                                Address = (string)reader["Address"];
                                NationalityID = (int)reader["NationalityID"];

                                if (reader["ImagePath"] == DBNull.Value)
                                    ImagePath = "";
                                else
                                    ImagePath = (string)reader["ImagePath"];

                                IsFound = true;
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
        public static int AddNewPerson(string NationNumber, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth, byte Gender, string Phone, string Email, string Address, int NationalityID, string ImagePath)
        {
            int PersonID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO [dbo].[People]
                   (NationalNumber,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Address,Gender,PhoneNumber,Email,NationalityID,ImagePath)
            VALUES (@NationalNumber,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Address,@Gender,@PhoneNumber,@Email,@NationalityID,@ImagePath);
                   SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNumber", NationNumber);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);

                        if (ThirdName == "")
                            command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);

                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@PhoneNumber", Phone);

                        if (Email == "")
                            command.Parameters.AddWithValue("@Email", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Email", Email);

                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@NationalityID", NationalityID);

                        if (ImagePath == "")
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);

                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            PersonID = InsertedID;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return PersonID;
        }
        public static bool UpdatePerson(int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName, string LastName,
             DateTime DateOfBirth, byte Gender, string Phone, string Email, string Address, int NationalityID, string ImagePath)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [dbo].[People]
                             SET [NationalNumber] = @NationalNumber,
                                 [FirstName] = @FirstName,
                                 [SecondName] = @SecondName,
                                 [ThirdName] = @ThirdName,
                                 [LastName] = @LastName,
                                 [DateOfBirth] = @DateOfBirth,
                                 [Address] = @Address,
                                 [Gender] = @Gender,
                                 [PhoneNumber] = @PhoneNumber,
                                 [Email] = @Email,
                                 [NationalityID] = @NationalityID,
                                 [ImagePath] = @ImagePath
                           WHERE PersonID = @PersonID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);

                        if (ThirdName == "")
                            command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);

                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@PhoneNumber", Phone);

                        if (Email == "")
                            command.Parameters.AddWithValue("@Email", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Email", Email);

                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@NationalityID", NationalityID);

                        if (ImagePath == "")
                            command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ImagePath", ImagePath);

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
        public static bool DeletePerson(int PersonID)
        {
            int RowsAffectd = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete from People where PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static DataTable GetAllPeople()
        {
            DataTable dtPeople = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "select * from People_View;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtPeople.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return dtPeople;
        }
        public static bool IsPersonExist(string NationalNumber)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT FOUND = 1 FROM PEOPLE WHERE NationalNumber = @NationalNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            IsFound = reader.HasRows;
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
