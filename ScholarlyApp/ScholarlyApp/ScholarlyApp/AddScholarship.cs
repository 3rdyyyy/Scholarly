using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScholarlyApp
{
    public partial class AddScholarship : Form
    {
        public AddScholarship()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Gather input from the textboxes
            string name = nameTextBox.Text.Trim();
            string description = descriptionTextBox.Text.Trim();
            string criteria = criteriaTextBox.Text.Trim();
            string amountText = amountTextBox.Text.Trim();
            string deadlineText = deadlineTextBox.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(criteria) ||
                string.IsNullOrEmpty(amountText) || string.IsNullOrEmpty(deadlineText))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount) || !DateTime.TryParse(deadlineText, out DateTime deadline))
            {
                MessageBox.Show("Amount must be a decimal and Deadline must be a valid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new scholarship instance and call the AddScholarship method
            Scholarship scholarship = new Scholarship();
            if (scholarship.AddScholarship(name, description, criteria, amount, deadline))
            {
                MessageBox.Show("Scholarship added successfully!");
                this.Close(); // Close the form after successful addition
            }
            else
            {
                MessageBox.Show("Error adding scholarship.");
            }
        }
    }
}
