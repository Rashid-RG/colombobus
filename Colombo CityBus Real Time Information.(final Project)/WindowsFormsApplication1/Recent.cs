using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CityBusManagement
{
    public partial class Recent : Form
    {
        public Recent()
        {
            InitializeComponent();
        }

        private void Recent_Load(object sender, EventArgs e)
        {
            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\OneDrive\Desktop\Colombo City-Bus-Management-System-master\WindowsFormsApplication1\BusInfo.mdf;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

               
                string busQuery = "SELECT BusNumber, Route FROM BusInfo"; 
                string driverQuery = "SELECT ID, firstname, lastname FROM DriverInfoTable "; 

                using (SqlCommand busCommand = new SqlCommand(busQuery, connection))
                using (SqlDataReader busReader = busCommand.ExecuteReader())
                {
                    if (busReader.Read())
                    {
                        busno.Text = busReader["BusNumber"].ToString();
                        route.Text = busReader["Route"].ToString();
                    }
                }

                using (SqlCommand driverCommand = new SqlCommand(driverQuery, connection))
                using (SqlDataReader driverReader = driverCommand.ExecuteReader())
                {
                    if (driverReader.Read())
                    {
                        id.Text = driverReader["ID"].ToString();
                        firstname.Text = driverReader["firstname"].ToString();
                        lastname.Text = driverReader["lastname"].ToString();
                    }
                }
            }
        }
    }
}
