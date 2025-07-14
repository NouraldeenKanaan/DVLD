using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsPeopleData
    {
        public static bool GetPersonInfoByID(int PersonID,ref string NationNumber,ref string FirstName,ref string SecondName,ref string ThirdName,ref string LastName,
             ref DateTime DateOfBirth,ref byte Gender,ref string Phone,ref string Email,ref string Address,ref int NationalityID,ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM PEOPLE WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

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

                reader.Close();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);  
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        public static bool GetPersonInfoByNationalNumber(string NationalNumber,ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
             ref DateTime DateOfBirth, ref byte Gender, ref string Phone, ref string Email, ref string Address, ref int NationalityID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM PEOPLE WHERE NationalNumber = @NationalNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

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

                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        public static int AddNewPerson(string NationNumber, string FirstName, string SecondName, string ThirdName, string LastName,
            DateTime DateOfBirth,byte Gender,string Phone,string Email,string Address,int NationalityID,string ImagePath)
        {
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[People]
                   (NationalNumber,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Address,Gender,PhoneNumber,Email,NationalityID,ImagePath)
            VALUES (@NationalNumber,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Address,@Gender,@PhoneNumber,@Email,@NationalityID,@ImagePath);
                   SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
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

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }

                connection.Close();
            }
            catch (Exception e)
            {
                return -1;
            }

            return PersonID;
            
        }
        public static bool UpdatePerson(int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName, string LastName,
             DateTime DateOfBirth, byte Gender, string Phone, string Email, string Address, int NationalityID, string ImagePath)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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


            SqlCommand command = new SqlCommand(query, connection);


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

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffected > 0);
        }
        public static bool DeletePerson(int PersonID)
        {           
            int RowsAffectd = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete from People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID",PersonID);

            try
            {
                connection.Open();
                RowsAffectd = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowsAffectd > 0);
        }
        public static DataTable GetAllPeople()
        {
            DataTable dtPeople = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from People_View;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dtPeople.Load(reader);

                reader.Close();
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

            return dtPeople;
        }
        public static bool IsPersonExist(string NationalNumber)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT FOUND = 1 FROM PEOPLE WHERE NationalNumber = @NationalNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;

                reader.Close();
            }
            catch 
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        
    }
    }
}
