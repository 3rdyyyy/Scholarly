using System;
using System.Data;
using System.Windows.Forms;

namespace ScholarlyApp
{
    public partial class ScholarshipsList : Form
    {
        public ScholarshipsList()
        {
            InitializeComponent();
        }

        private void ScholarshipsList_Load(object sender, EventArgs e)
        {
            LoadScholarships();
        }

        private void LoadScholarships()
        {
            DataTable scholarshipsTable = Scholarship.GetAllScholarships();

            if (scholarshipsTable.Rows.Count > 0)
            {
                dataGridViewScholarships.DataSource = scholarshipsTable;
            }
            else
            {
                MessageBox.Show("No available scholarship", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
