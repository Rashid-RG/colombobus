using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CityBusManagement

{
    public partial class showAll : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Desktop\Colombo City-Bus-Management-System-master\WindowsFormsApplication1\BusInfo.mdf;Integrated Security=True;Connect Timeout=30;";

        public showAll()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            listBox_details.Items.Clear();
            progressBar1.Value = 0;

            if (txtBox_busNo.Text.Equals(""))
            {
                MessageBox.Show("Please fill the box");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string selectBusQuery = "SELECT * FROM BusInfo WHERE BusNumber = @busNumber";
                        string selectDriverQuery = "SELECT * FROM DriverInfoTable WHERE BusNumber = @busNumber";

                        using (SqlCommand command = new SqlCommand(selectBusQuery, connection))
                        {
                            command.Parameters.AddWithValue("@busNumber", txtBox_busNo.Text);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    listBox_details.Items.Add($"Bus Number: {reader["BusNumber"]}");
                                    listBox_details.Items.Add($"Transit: {reader["Transit"]}");
                                    listBox_details.Items.Add($"Fare: {reader["Fare"]}");
                                    listBox_details.Items.Add($"Route: {reader["Route"]}");
                                    listBox_details.Items.Add($"Start Time: {reader["StartTime"]}");
                                    listBox_details.Items.Add($"End Time: {reader["EndTime"]}");

                                    progressBar1.Value = 50; 

                                    reader.Close(); 

                                    using (SqlCommand driverCommand = new SqlCommand(selectDriverQuery, connection))
                                    {
                                        driverCommand.Parameters.AddWithValue("@busNumber", txtBox_busNo.Text);

                                        using (SqlDataReader driverReader = driverCommand.ExecuteReader())
                                        {
                                            if (driverReader.Read())
                                            {
                                                listBox_details.Items.Add("");
                                                listBox_details.Items.Add("Driver Details:");
                                                listBox_details.Items.Add($"Driver ID: {driverReader["ID"]}");
                                                listBox_details.Items.Add($"Driver First Name: {driverReader["FirstName"]}");
                                                listBox_details.Items.Add($"Driver Last Name: {driverReader["LastName"]}");

                                                progressBar1.Value = 100; 
                                            }
                                            else
                                            {
                                                MessageBox.Show("There is no Driver for this Bus");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("There is no Bus with that Number");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

       
        }
    }

