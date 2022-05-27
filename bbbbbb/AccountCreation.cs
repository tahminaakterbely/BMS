using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bbbbbb
{
    public partial class AccountCreation : Form
    {
        public AccountCreation()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("Server = localhost; database = bms; username = root; password =;");




        public void custid()
        {
            con.Open();

            string query = "select max(custid)from customer";

            MySqlCommand cmd = new MySqlCommand(query, con);

            MySqlDataReader dr;

            dr = cmd.ExecuteReader();

             if(dr.Read())
            {
                string val = dr[0].ToString();

                if(val == "")
                {
                    label14.Text = "10000";

                }
                else
                {
                    int a;
                    a = int.Parse(dr[0].ToString());
                    a = a + 1;
                    label14.Text = a.ToString();
                }
            }
            con.Close();
        }

        private void AccountCreation_Load(object sender, EventArgs e)
        {
            custid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            button3.BackColor = ColorTranslator.FromHtml("#16ef4f");
            button4.BackColor = ColorTranslator.FromHtml("#ef8716");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            button4.BackColor = ColorTranslator.FromHtml("#ef8716");
            button3.BackColor = ColorTranslator.FromHtml("#16ef4f");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cid, lname, fname, street, city, state, phone, date, email, acno, acctype, des, bal;


            cid = label14.Text;
            lname = txtlname.Text;
            fname = txtfname.Text;
            street = txtstreet.Text;
            city = txtcity.Text;
            state = txtstate.Text;
            phone = txtphone.Text;
            date = txtdate.Text;
            email = txtemail.Text;
            acno = txtacc.Text;
            acctype = txtacctype.Text;
            des = txtdes.Text;
            bal = txtbal.Text;

            //MySqlTransaction transation;

            //transation = con.BeginTransaction();

            //cmd.Transaction = transation;

            try
            {
                con.Open();

                string query1 = "insert into customer (custid,lastname,firstname,street,city,state,phone,date,email) values ('" + cid + "','" + lname + "','" + fname + "','" + street + "','" + city + "','" + state + "','" + phone + "','" + date + "','" + email + "')";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                cmd1.ExecuteNonQuery();
                
                string query2 = "insert into account (accid,custid,acctype,description,balance) values ('" + acno + "', '" + cid + "', '"  + acctype + "','" + des + "', '" + bal + "')";
                MySqlCommand cmd2 = new MySqlCommand(query2, con);
                cmd2.ExecuteNonQuery();

                //transation.Commit();

                MessageBox.Show("Record added..........");


            }
            catch(Exception ex)
            {
                //transation.Rollback();
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
                
                    

                
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
