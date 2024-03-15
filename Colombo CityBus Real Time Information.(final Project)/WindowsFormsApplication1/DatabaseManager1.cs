using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBusManagement
{
    internal class DatabaseManager1
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Desktop\Colombo City-Bus-Management-System-master\WindowsFormsApplication1\BusInfo.mdf;Integrated Security=True;";

        public void InsertDriverInfo(string id, string firstName, string lastName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO DriverInfo (ID, FirstName, LastName) " +
                                   "VALUES (@id, @firstName, @lastName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting driver info: " + ex.ToString());
                throw; // Re-throw the exception for proper error handling
            }
        }
    }
}