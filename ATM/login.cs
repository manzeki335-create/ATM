using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            ACCOUNT acc=new ACCOUNT();
            acc.Show();
            this.Hide();
        }
        public static string AccNumber;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lab 5\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void label5_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter sd = new SqlDataAdapter("select count(*) from AccountTB1 where Accnum='" + accnumtb.Text + "' and PIN = " + pincodetb.Text + "", con);
            DataTable dt = new DataTable();
                         sd.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    AccNumber = accnumtb.Text;
                    HOME hOME = new HOME();
                    hOME.Show();
                    this.Hide();
                    con.Close();
                }
                else if (dt.Rows[0][0].ToString() == "0")
                {
                    MessageBox.Show("please enter account and pin number");
                }
                else
                    {
                        MessageBox.Show("wrong Account number or pin code");
                }
                con.Close();
            }
                 
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pincodetb_TextChanged(object sender, EventArgs e)
        {
            string pinCode = pincodetb.Text;

            // Simple validation: Check if the PIN is 4 digits
            if (pinCode.Length == 10 && int.TryParse(pinCode, out _))
            {
                MessageBox.Show("PIN is valid.");
            }
            else
            {
               // MessageBox.Show("Please enter a valid PIN.");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            pincodetb.PasswordChar = '*';
        }

        private void accnumtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
