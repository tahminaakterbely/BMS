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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server = localhost;database = bms;username = root; password = ;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string str = "select * from account where accid = '"+textBox1.Text+"'";
                MySqlCommand cmd = new MySqlCommand(str, con);

                DataTable dt = new DataTable();

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["balance"].ToString();
                }



                /*MySqlDataReader rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    txtbal.Text = rd[4].ToString(); 
                }*/









            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string acno, date;
            double bal, deposit;

            acno = textBox1.Text;
            date = dateTimePicker1.Text;
            bal = double.Parse(textBox2.Text);
            deposit = double.Parse(textBox3.Text);



            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            MySqlTransaction transaction = con.BeginTransaction();

            cmd.Connection = con;
            cmd.Transaction = transaction;

            try
            {
                cmd.CommandText = "update account set balance = balance + '"+deposit+"' where accid = '"+acno+"' ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "insert into transaction(accid,data,bal,deposit)values('"+acno+"','"+date+"','"+bal+"','"+deposit+"')";

                cmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("transaction success");







            }
            catch(Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.ToString());
            
            }
            finally
            { con.Close();
            
            
            }
        }
    }
}
