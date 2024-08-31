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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registerLink_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the username and password from the textboxes
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            // Validate that none of the fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Both fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new user instance
            User user = new User();

            // Attempt to login and get the role
            if (user.Login(username, password, out string role))
            {
                // Open the appropriate dashboard based on the role
                if (role == "Admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard(username);
                    adminDashboard.Show();
                }
                else if (role == "Student")
                {
                    UserDashboard userDashboard = new UserDashboard(username);
                    userDashboard.Show();
                }
                else
                {
                    MessageBox.Show("Unrecognized role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
