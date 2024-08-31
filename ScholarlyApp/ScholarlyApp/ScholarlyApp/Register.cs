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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get trimmed values from textboxes
            string email = regEmail.Text.Trim();
            string username = regUsername.Text.Trim();
            string password = regPassword.Text.Trim();

            // Validate that none of the fields are empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new user instance and set its properties
            User newUser = new User
            {
                Email = email,
                Username = username,
                Password = password
            };

            // Register the user and display appropriate message
            if (newUser.Register())
            {
                MessageBox.Show("User registered successfully!");
            }
            else
            {
                MessageBox.Show("Error registering user.");
            }
        }

        private void loginLink_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
