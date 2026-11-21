using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class DEPOSIT : Form
    {
        public DEPOSIT()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lab 5\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = login.AccNumber;
        private void addtransaction()
        {
            string TrType = "deposit";
            try
            {
                con.Open();
                string query = "insert into TransactionTB1 values('" + Acc + "','" + TrType + "','" + depamttb.Text + "','" + DateTime.Today.Date.ToString() + "') ";
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
        private void label13_Click(object sender, EventArgs e)
        {
           
        }

        private void label14_Click(object sender, EventArgs e)
        {
        
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndeposit_Click(object sender, EventArgs e)
        {
            if (depamttb.Text == "" || Convert.ToInt32(depamttb.Text) <= 0)
            {
                MessageBox.Show("enter the amount to deposit");
            }
            else
            {

                newbalance = oldbalance + Convert.ToInt32(depamttb.Text);
                try
                {
                    con.Open();
                    string query = "update AccountTB1 set BALANCE=" + newbalance + "where ACCNUM='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("success Deposit");
                   con.Close();
                    addtransaction();
                    HOME hOME = new HOME();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DEPOSIT_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           HOME hOME = new HOME();
            hOME.Show();
            this.Hide();
        }
        int oldbalance, newbalance;
        private void getbalance()
        {
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select BALANCE from AccountTB1 where ACCNUM='" + Acc + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
    }
}
