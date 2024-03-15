using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CityBusManagement
{
    internal class DatabaseManager
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Desktop\Colombo City-Bus-Management-System-master\WindowsFormsApplication1\BusInfo.mdf;Integrated Security=True;";

        public void InsertBusInfo(string busNumber, string transit, string fare, string route, string startTime, string endTime)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO BusInfo (BusNumber, Transit, Fare, Route, StartTime, EndTime) " +
                               "VALUES (@busNumber, @transit, @fare, @route, @startTime, @endTime)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@busNumber", busNumber);
                    command.Parameters.AddWithValue("@transit", transit);
                    command.Parameters.AddWithValue("@fare", fare);
                    command.Parameters.AddWithValue("@route", route);
                    command.Parameters.AddWithValue("@startTime", startTime);
                    command.Parameters.AddWithValue("@endTime", endTime);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertDriverInfo(string id, string firstName, string lastName, string busNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO DriverInfoTable (ID, FirstName, LastName, BusNumber) " +
                                   "VALUES (@id, @firstName, @lastName, @busNumber)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@busNumber", busNumber);

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
