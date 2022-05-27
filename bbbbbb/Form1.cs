using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbbbbb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtuser.Text;
            password = txtpass.Text;

            count = count + 1;

            if(count>3)
            {
                MessageBox.Show("System has been blocked................");
                Application.Exit();
            }
            if (username == "" && password == "")
            {
                label4.Text = "Blank not allow";
            }
            else if (username.Length >= 10 & password.Length >= 10)
            {
                label4.Text = "10 Character only allowed";
            }
            else
            {


                if (username == "bely" && password == "123")
                {
                    //label4.Text = "Login successfully";

                    Progrbar pr = new Progrbar();
                    this.Hide();
                    pr.Show();



                }

                else
                {
                    label4.Text = "invalid username and password";
                    txtuser.Clear();
                    txtpass.Clear();
                    txtuser.Focus();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
