using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ScholarlyApp
{
    public class Scholarship
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Criteria { get; set; }
        public decimal Amount { get; set; }
        public DateTime Deadline { get; set; }

        private static string connectionString = ConfigurationManager.ConnectionStrings["ScholarlyAppDb"].ConnectionString;

        public static DataTable GetAllScholarships()
        {
            DataTable scholarshipsTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Scholarships";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(scholarshipsTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            return scholarshipsTable;
        }

        public bool AddScholarship(string name, string description, string criteria, decimal amount, DateTime deadline)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Scholarships (Name, Description, Criteria, Amount, Deadline) " +
                               "VALUES (@Name, @Description, @Criteria, @Amount, @Deadline)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Criteria", criteria);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Deadline", deadline);

                    try
                    {
                        connection.Open();  
                        int result = command.ExecuteNonQuery();
                        return result > 0; // Return true if the insert was successful
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
