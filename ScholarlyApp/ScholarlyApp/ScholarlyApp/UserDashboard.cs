using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace ScholarlyApp
{
    public partial class UserDashboard : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public UserDashboard(string username)
        {
            InitializeComponent();
            userNameLbl.Text = username;

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Close(); 
        }

        private void lblScholarships_Click(object sender, EventArgs e)
        {
            ScholarshipsList list = new ScholarshipsList();
            list.Show();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            // Gather input from the textboxes
            string nameOfScholarship = nameOfScholarshipText.Text.Trim();
            string school = schoolTextBox.Text.Trim();
            string genAveText = genAveTextBox.Text.Trim();
            string course = courseTextbox.Text.Trim();
            string studentIDText = studentIDTextbox.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(nameOfScholarship) || string.IsNullOrEmpty(school) ||
                string.IsNullOrEmpty(genAveText) || string.IsNullOrEmpty(course) ||
                string.IsNullOrEmpty(studentIDText))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(studentIDText, out int studentID) || !decimal.TryParse(genAveText, out decimal genAve))
            {
                MessageBox.Show("Student ID must be an integer and General Average must be a decimal.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the scholarship ID (assuming you have a method to get it based on the scholarship name)
            int scholarshipID = GetScholarshipIDByName(nameOfScholarship);
            if (scholarshipID == -1)
            {
                MessageBox.Show("Scholarship not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new application instance and call the Apply method
            Application application = new Application();
            if (application.Apply(studentID, scholarshipID, genAve, course, school))
            {
                MessageBox.Show("Application submitted successfully!");
            }
            else
            {
                MessageBox.Show("Error submitting application.");
            }
        }

        private int GetScholarshipIDByName(string name)
        {
       
            DataTable scholarshipsTable = Scholarship.GetAllScholarships();
            DataRow[] foundRows = scholarshipsTable.Select($"Name = '{name}'");
            if (foundRows.Length > 0)
            {
                return (int)foundRows[0]["ID"];
            }
            return -1;
        }

        private void lblSubmissions_Click(object sender, EventArgs e)
        {
            MyApplications appViews = new MyApplications();
            appViews.Show();
        }
    }
}
