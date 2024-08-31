using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ScholarlyApp
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "Student"; 
        public string Email { get; set; }

        private string connectionString = ConfigurationManager.ConnectionStrings["ScholarlyAppDb"].ConnectionString;

        public bool Register()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, Password, Role, Email) VALUES (@Username, @Password, @Role, @Email)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Role", Role);
                    command.Parameters.AddWithValue("@Email", Email);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        return result > 0; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool Login(string username, string password, out string role)
        {
            role = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            role = reader["Role"].ToString();
                            return true; 
                        }
                        return false; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}
