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

    public partial class addDriver : Form
    {
        public addDriver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please fill in all the boxes!");
            }
            else
            {
                try
                {
                    // Retrieve driver information from input fields
                    string id = textBox1.Text;
                    string firstName = textBox3.Text;
                    string lastName = textBox2.Text;
                    string busNumber = textBox4.Text;  // Assuming you have an input field for Bus Number

                    // Call the DatabaseManager to insert driver info
                    DatabaseManager dbManager = new DatabaseManager();
                    dbManager.InsertDriverInfo(id, firstName, lastName, busNumber);

                    MessageBox.Show("Driver added Successfully");

                    // Clear input fields
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mainForm = new Main();

            mainForm.Owner = this;
            mainForm.Show();
            this.Hide();
        }
    }
}