using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CityBusManagement
{
    internal class Connect
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DELL\OneDrive\Desktop\Colombo City-Bus-Management-System-master\WindowsFormsApplication1\loginandregistration.mdf"";Integrated Security=True";
    }
}
