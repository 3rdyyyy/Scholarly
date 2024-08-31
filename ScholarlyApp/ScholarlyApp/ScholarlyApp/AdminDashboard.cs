using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace ScholarlyApp
{
    public partial class AdminDashboard : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public AdminDashboard(string username)
        {
            InitializeComponent();


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

            LoadApplications();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void btnAddScholarship_Click(object sender, EventArgs e)
        {
            AddScholarship addScholarshipForm = new AddScholarship();
            addScholarshipForm.ShowDialog();
            LoadApplications(); // Reload applications after adding a scholarship
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (submittedApplications.SelectedRows.Count > 0)
            {
                int applicationID = Convert.ToInt32(submittedApplications.SelectedRows[0].Cells["ID"].Value);
                if (Application.UpdateApplicationStatus(applicationID, "Approved"))
                {
                    MessageBox.Show("Application approved successfully!");
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Error approving application.");
                }
            }
            else
            {
                MessageBox.Show("Please select an application to approve.");
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (submittedApplications.SelectedRows.Count > 0)
            {
                int applicationID = Convert.ToInt32(submittedApplications.SelectedRows[0].Cells["ID"].Value);
                if (Application.UpdateApplicationStatus(applicationID, "Rejected"))
                {
                    MessageBox.Show("Application rejected successfully!");
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Error rejecting application.");
                }
            }
            else
            {
                MessageBox.Show("Please select an application to reject.");
            }
        }

        private void LoadApplications()
        {
            DataTable applicationsTable = Application.GetAllApplications();

            if (applicationsTable.Rows.Count > 0)
            {
                submittedApplications.DataSource = applicationsTable;
            }
            else
            {
                MessageBox.Show("No applications available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddScholarship_Click_1(object sender, EventArgs e)
        {
            AddScholarship addScholarshipForm = new AddScholarship();
            addScholarshipForm.ShowDialog();
            LoadApplications();
        }

        private void btnReject_Click_1(object sender, EventArgs e)
        {
            if (submittedApplications.SelectedRows.Count > 0)
            {
                int applicationID = Convert.ToInt32(submittedApplications.SelectedRows[0].Cells["ID"].Value);
                if (Application.UpdateApplicationStatus(applicationID, "Rejected"))
                {
                    MessageBox.Show("Application rejected successfully!");
                    LoadApplications();
                }
                else
                {
                    MessageBox.Show("Error rejecting application.");
                }
            }
            else
            {
                MessageBox.Show("Please select an application to reject.");
            }

        }
    }
}
