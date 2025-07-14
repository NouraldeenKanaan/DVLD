using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsUsersData
    {
        public static bool GetUserInfoByUsernameAndPassword(string Username, string Password, ref int UserID, ref int PersonID, ref bool IsActive)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "select * from Users where Username = @Username and Password = @Password;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                IsActive = (bool)reader["IsActive"];
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
        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string Username, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "select * from Users where UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = (int)reader["PersonID"];
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
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
        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT Users.UserID, People.PersonID,FullName = FirstName + ' ' + SecondName + ' ' + ISNULL(ThirdName,'') + ' ' + LastName,
                             Users.Username, Users.IsActive FROM Users INNER JOIN
                         People ON Users.PersonID = People.PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtUsers.Load(reader);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return dtUsers;
        }
        public static int AddNewUser(int PersonID, string Username, string Password, bool IsActive)
        {
            int UserID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"INSERT INTO [dbo].[Users] (PersonID,Username,Password,IsActive)
                                               VALUES
                                                      (@PersonID,@Username,@Password,@IsActive);
                              SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            UserID = InsertedID;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return UserID;
        }
        public static bool UpdateUser(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [dbo].[Users]
                                                SET   [PersonID] = @PersonID,
                                                      [Username] = @Username,
                                                      [Password] = @Password,
                                                      [IsActive] = @IsActive
                                                WHERE UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

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
        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"Delete from Users where UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);

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
        public static bool IsUserExists(string Username)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = "Select Found = 1 from Users where Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);

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
        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"SELECT Found = 1 FROM Users INNER JOIN
                                          People ON Users.PersonID = People.PersonID
                                          where Users.PersonID = @PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

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
        public static bool ChangePassword(int UserID, string NewPassword)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    string query = @"UPDATE [dbo].[Users]
                                                SET [Password] = @Password
                                                WHERE UserID = @UserID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Password", NewPassword);

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
