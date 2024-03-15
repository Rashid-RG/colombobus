using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CityBusManagement
{
    public partial class Update : Form
    {
        
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DELL\OneDrive\Desktop\Colombo City-Bus-Management-System-master\WindowsFormsApplication1\BusInfo.mdf""";

        public Update()
        {
            InitializeComponent();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_BusNo.Text) || string.IsNullOrWhiteSpace(textBox_routeName.Text) || string.IsNullOrWhiteSpace(textBox_newRouteName.Text))
            {
                MessageBox.Show("Please fill all the boxes");
            }
            else
            {
                string busNumber = textBox_BusNo.Text;
                string oldRouteName = textBox_routeName.Text;
                string newRouteName = textBox_newRouteName.Text;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                       
                        string updateQuery = "UPDATE BusInfo SET Route = @newRouteName WHERE BusNumber = @busNumber AND Route = @oldRouteName";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@busNumber", busNumber);
                            command.Parameters.AddWithValue("@oldRouteName", oldRouteName);
                            command.Parameters.AddWithValue("@newRouteName", newRouteName);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Route Updated in the database!");
                            }
                            else
                            {
                                MessageBox.Show("No matching records found to update.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating route: " + ex.Message);
                }

                
                string path = busNumber + ".txt";
                if (File.Exists(path))
                {
                    string text = File.ReadAllText(path);
                    text = text.Replace(oldRouteName, newRouteName);
                    File.WriteAllText(path, text);
                    MessageBox.Show("Route Updated in the text file!");
                }
                else
                {
                    MessageBox.Show("There is no Bus with that Number");
                }
            }
        }
    }
}

