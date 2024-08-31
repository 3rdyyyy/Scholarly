using System;
using System.Data;
using System.Windows.Forms;

namespace ScholarlyApp
{
    public partial class MyApplications : Form
    {
        public MyApplications()
        {
            InitializeComponent();
        }

        private void MyApplications_Load(object sender, EventArgs e)
        {
            LoadApplications();
        }

        private void LoadApplications()
        {
            DataTable applicationsTable = Application.GetAllApplications();

            if (applicationsTable.Rows.Count > 0)
            {
                ApplicationsView.DataSource = applicationsTable;
            }
            else
            {
                MessageBox.Show("No available applications", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
