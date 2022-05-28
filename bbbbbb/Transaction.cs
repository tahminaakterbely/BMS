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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server = localhost;database = bms;username = root; password = ;");

        private void button1_Click(object sender, EventArgs e)
        {
            string fno, tono, date;
            double bal;

            fno = ftxt.Text;
            tono =totxt.Text;
            date =txtdate.Text;
            bal = double.Parse(txtamount.Text);


            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction transaction = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transaction;

            try
            {
                cmd.CommandText = "update account set balance = balance - '" + bal + "' where accid = '" + fno + "' ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "update account set balance = balance + '" + bal + "' where accid = '" + tono + "' ";
                cmd.ExecuteNonQuery();




                cmd.CommandText = "insert into transfer(f_acc,to_acc,date,amount)values('" + fno + "','" + tono + "','" + date + "','" + bal + "')";

                cmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("transaction success");







            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                con.Close();


            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            var m = new Main();
            m.Show();
            this.Hide();
        }
    }
}
