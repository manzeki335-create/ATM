using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class FAST_CASH : Form
    {
        public FAST_CASH()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
     
        }
        private void FAST_CASH_Load(object sender, EventArgs e)
        {
            getbalance();
        }
       // int amt1=100,amt2=500,amt3=1000,amt4=2000,amt5=5000,amt6=10000;
        private void addtransaction1()
        {
            string TrType = "withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTB1 values('" + Acc + "','" + TrType + "','" + 100 + "','" + DateTime.Today.Date.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account created successfully");
                con.Close();
                login log = new login();
                log.Show();
                this.Hide();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }
        private void addtransaction2()
        {
            string TrType = "withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTB1 values('" + Acc + "','" + TrType + "','" + 500 + "','" + DateTime.Today.Date.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account created successfully");
                con.Close();
                login log = new login();
                log.Show();
                this.Hide();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }
        private void addtransaction3()
        {
            string TrType = "withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTB1 values('" + Acc + "','" + TrType + "','" + 1000 + "','" + DateTime.Today.Date.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account created successfully");
                con.Close();
                login log = new login();
                log.Show();
                this.Hide();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }
        private void addtransaction4()
        {
            string TrType = "withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTB1 values('" + Acc + "','" + TrType + "','" + 2000 + "','" + DateTime.Today.Date.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account created successfully");
                con.Close();
                login log = new login();
                log.Show();
                this.Hide();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }
        private void addtransaction5()
        {
            string TrType = "withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTB1 values('" + Acc + "','" + TrType + "','" + 5000 + "','" + DateTime.Today.Date.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account created successfully");
                con.Close();
                login log = new login();
                log.Show();
                this.Hide();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }
        private void addtransaction6()
        {
            string TrType = "withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTB1 values('" + Acc + "','" + TrType + "','" + 10000 + "','" + DateTime.Today.Date.ToString() + "') ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Account created successfully");
                con.Close();
                login log = new login();
                log.Show();
                this.Hide();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }
        private void label10_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("insufficient balance");
            }
            else {
                int newbalance = bal - 100;
                try
                {
                    con.Open();
                    string query = "update AccountTB1 set BALANCE=" + newbalance + "where ACCNUM='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("success withdraw");
                    con.Close();
                    addtransaction1();
                    HOME hOME = new HOME();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("insufficient balance");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    con.Open();
                    string query = "update AccountTB1 set BALANCE=" + newbalance + "where ACCNUM='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("success withdraw");
                    con.Close();
                    addtransaction2();
                    HOME hOME = new HOME();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("insufficient balance");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    con.Open();
                    string query = "update AccountTB1 set BALANCE=" + newbalance + "where ACCNUM='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("success withdraw");
                    con.Close();
                    addtransaction3();
                    HOME hOME = new HOME();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("insufficient balance");
            }
            else
            {
                int newbalance = bal - 2000;
                try
                {
                    con.Open();
                    string query = "update AccountTB1 set BALANCE=" + newbalance + "where ACCNUM='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("success withdraw");
                    con.Close();
                    addtransaction4();
                    HOME hOME = new HOME();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("insufficient balance");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    con.Open();
                    string query = "update AccountTB1 set BALANCE=" + newbalance + "where ACCNUM='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("success withdraw");
                    con.Close();
                    addtransaction5();
                    HOME hOME = new HOME();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("insufficient balance");
            }
            else
            {
                int newbalance = bal - 10000;
                try
                {
                    con.Open();
                    string query = "update AccountTB1 set BALANCE=" + newbalance + "where ACCNUM='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("success withdraw");
                    con.Close();
                    addtransaction6();
                    HOME hOME = new HOME();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            hOME.Show();
            this.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lab 5\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = login.AccNumber;
        int bal;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select BALANCE from AccountTB1 where ACCNUM='" + Acc + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
           // avbalancelbl.Text = "Balance Rs" + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }

        private void avbalancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
