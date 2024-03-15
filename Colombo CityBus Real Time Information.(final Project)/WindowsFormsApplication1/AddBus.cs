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
using System.Globalization;

namespace CityBusManagement
{
    public partial class Form1 : Form
    {
       
            private DatabaseManager dbManager;

            public Form1()
            {
                InitializeComponent();
                textBox5.Focus();

                dbManager = new DatabaseManager();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (textBox2.Text.Equals("") || textBox1.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals(""))
                {
                    MessageBox.Show("Please fill all boxes!");
                }
                else
                {
                    try
                    {
                        CultureInfo provider = CultureInfo.InvariantCulture;
                        string[] formats = { "yyyy-MM-dd HH:mm:ss", "yyyy/MM/dd HH:mm:ss" };

                        if (DateTime.TryParseExact(textBox1.Text, formats, provider, DateTimeStyles.None, out DateTime startTime) &&
                            DateTime.TryParseExact(textBox0.Text, formats, provider, DateTimeStyles.None, out DateTime endTime))
                        {
                            dbManager.InsertBusInfo(textBox5.Text, textBox4.Text, textBox3.Text, textBox2.Text, startTime.ToString("yyyy-MM-dd HH:mm:ss"), endTime.ToString("yyyy-MM-dd HH:mm:ss"));

                            MessageBox.Show("Record Added");

                            textBox4.Text = " ";
                            textBox5.Text = " ";
                            textBox3.Text = " ";
                            textBox1.Text = " ";
                            textBox2.Text = " ";
                            textBox0.Text = " ";

                            Form ad = new addDriver();
                            ad.Owner = this;
                            ad.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid date/time format.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }