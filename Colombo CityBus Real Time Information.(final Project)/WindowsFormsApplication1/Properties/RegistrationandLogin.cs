using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CityBusManagement.Properties
{
    public partial class RegistrationandLogin : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Desktop\Colombo City-Bus-Management-System-master\WindowsFormsApplication1\Properties\Database1.mdf;Integrated Security=True;";
        private bool isAuthenticated = false;

        public RegistrationandLogin()
        {
            InitializeComponent();
        }

        // Hash a password using SHA256
        private static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        public bool IsAuthenticated
        {
            get { return isAuthenticated; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show the signup form
            signupForm.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usernameNewTxt.Text != "" && passwordNewTxt.Text != "")
            {
                try
                {
                    // Hash the password before storing it
                    string hashedPassword = HashPassword(passwordNewTxt.Text);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if the username already exists
                        string checkUserQuery = "SELECT COUNT(*) FROM userTable WHERE username = @username";
                        using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
                        {
                            checkUserCommand.Parameters.AddWithValue("@username", usernameNewTxt.Text);
                            int userCount = (int)checkUserCommand.ExecuteScalar();

                            if (userCount > 0)
                            {
                                MessageBox.Show("Username already exists. Choose a different username.");
                            }
                            else
                            {
                                // Insert the new user into the database
                                string insertUserQuery = "INSERT INTO userTable (username, password) VALUES (@username, @password)";
                                using (SqlCommand insertUserCommand = new SqlCommand(insertUserQuery, connection))
                                {
                                    insertUserCommand.Parameters.AddWithValue("@username", usernameNewTxt.Text);
                                    insertUserCommand.Parameters.AddWithValue("@password", hashedPassword);
                                    insertUserCommand.ExecuteNonQuery();
                                }

                                MessageBox.Show("Signup has been completed.");
                                isAuthenticated = true; // Set authentication flag
                                signupForm.Visible = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text != "" && passwordTxt.Text != "")
            {
                try
                {
                    // Hash the entered password for comparison
                    string hashedPassword = HashPassword(passwordTxt.Text);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string checkUserQuery = "SELECT COUNT(*) FROM userTable WHERE username = @username AND password = @password";
                        using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
                        {
                            checkUserCommand.Parameters.AddWithValue("@username", usernameTxt.Text);
                            checkUserCommand.Parameters.AddWithValue("@password", hashedPassword);
                            int userCount = (int)checkUserCommand.ExecuteScalar();

                            if (userCount == 1)
                            {
                                MessageBox.Show("Login successful.");
                                isAuthenticated = true; // Set authentication flag
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username or password is incorrect.");
                                isAuthenticated = false; // Clear authentication flag
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            isAuthenticated = false; // Clear authentication flag
            //Clear username and password fields
            usernameTxt.Text = "";
           passwordTxt.Text = "";
        }
    }
}