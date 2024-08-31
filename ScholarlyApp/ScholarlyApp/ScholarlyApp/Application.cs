using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace ScholarlyApp
{
    public class Application
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int ScholarshipID { get; set; }
        public string Status { get; set; }
        public DateTime DateSubmitted { get; set; }
        public decimal GeneralAverage { get; set; }
        public string Course { get; set; }
        public string School { get; set; }

        private static string connectionString = ConfigurationManager.ConnectionStrings["ScholarlyAppDb"].ConnectionString;

        public bool Apply(int studentID, int scholarshipID, decimal generalAverage, string course, string school)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Applications (StudentID, ScholarshipID, Status, DateSubmitted, GeneralAverage, Course, School) " +
                               "VALUES (@StudentID, @ScholarshipID, @Status, @DateSubmitted, @GeneralAverage, @Course, @School)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@ScholarshipID", scholarshipID);
                    command.Parameters.AddWithValue("@Status", "Pending");
                    command.Parameters.AddWithValue("@DateSubmitted", DateTime.Now);
                    command.Parameters.AddWithValue("@GeneralAverage", generalAverage);
                    command.Parameters.AddWithValue("@Course", course);
                    command.Parameters.AddWithValue("@School", school);

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

        public static DataTable GetAllApplications()
        {
            DataTable applicationsTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Applications WHERE Status != 'Rejected'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(applicationsTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
            return applicationsTable;
        }

        public static bool UpdateApplicationStatus(int applicationID, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Applications SET Status = @Status WHERE ID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@ID", applicationID);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0; // Return true if the update was successful
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
