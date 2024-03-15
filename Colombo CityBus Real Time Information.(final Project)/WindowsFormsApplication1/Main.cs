using CityBusManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBusManagement
{
    public partial class Main : Form

    {
        private bool isAuthenticated = false; 
        private TextBox passwordTxt;
        private TextBox usernameTxt;

        public Main()
        {
            InitializeComponent();
            passwordTxt = new TextBox();
        }

        



            private void button1_Click_1(object sender, EventArgs e)
            {
                if (isAuthenticated) {
                    Form add = new Form1();
                    add.Owner = this;
                    add.Show();
                }

                else
                {
                    MessageBox.Show("Please log in to access this feature.");
                    ShowLoginScreen();
                }
            }

            private void button2_Click_1(object sender, EventArgs e)
            {
                if (isAuthenticated) {
                    Form add = new addDriver();
                    add.Owner = this;
                    add.Show();
                }

                else
                {
                    MessageBox.Show("Please log in to access this feature.");
                    ShowLoginScreen();
                }
            }

            private void button3_Click(object sender, EventArgs e)
            {
                if (isAuthenticated) {
                    Form add = new DeleteBus();
                    add.Owner = this;
                    add.Show();
                }

                else
                {
                    MessageBox.Show("Please log in to access this feature.");
                    ShowLoginScreen();
                }
            }

            private void button4_Click_1(object sender, EventArgs e)
            {
                if (isAuthenticated)
                {
                    Form add = new Update();
                    add.Owner = this;
                    add.Show();
                }
                else
                {
                    MessageBox.Show("Please log in to access this feature.");
                    ShowLoginScreen();
                }

            }

            private void button5_Click(object sender, EventArgs e)
            {
                if (isAuthenticated)
                {
                    Form add = new Recent();
                    add.Owner = this;
                    add.Show();
                }
                else
                {
                    MessageBox.Show("Please log in to access this feature.");
                    ShowLoginScreen();
                }
            }

            private void button6_Click_1(object sender, EventArgs e)
            {
                if (isAuthenticated) {
                    Form add = new showAll();
                    add.Owner = this;
                    add.Show();
                }
                else
                {
                    MessageBox.Show("Please log in to access this feature.");
                    ShowLoginScreen();
                }
            }


            private void button7_Click_1(object sender, EventArgs e)
            {
                ShowLoginScreen();
            }

            
            private void ShowLoginScreen()
            {
                RegistrationandLogin loginForm = new RegistrationandLogin();
                loginForm.Owner = this;
                loginForm.ShowDialog();

               
                isAuthenticated = loginForm.IsAuthenticated;
            }

        
    }
    } 