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
    public partial class WITHDRAW : Form
    {
        public WITHDRAW()
        {
            InitializeComponent();
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
          //  abalancelbl.Text = "Balance Rs" + dt.Rows[0][0].ToString();
            bal=Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void addtransaction()
        {
            string TrType = "withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTB1 values('" + Acc + "','" + TrType + "','" + wdamttb.Text + "','" + DateTime.Today.Date.ToString() + "') ";
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
        private void WITHDRAW_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int  newbalance;
        private void label13_Click(object sender, EventArgs e)
        {
            if (wdamttb.Text == "")
            {
                MessageBox.Show("missing information");
            } else if (Convert.ToInt32(wdamttb.Text) <= 100) {
                MessageBox.Show("enter a valid amount");
            }
            else if (Convert.ToInt32(wdamttb.Text) > 50)
            {
                MessageBox.Show("insufficient balance ");
            }
            else {
                try
                {

                    newbalance = bal - Convert.ToInt32(wdamttb.Text);
                    try
                    {
                        con.Open();
                        string query = "update AccountTB1 set BALANCE=" + newbalance + "where ACCNUM='" + Acc + "';";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("success withdraw");
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
                catch (Exception ex) { 
                MessageBox.Show(ex.Message);
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME home=new HOME();
            home.Show();
        }

        private void abalancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
