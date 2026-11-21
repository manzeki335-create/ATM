using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATM
{
    public partial class CHANGEPIN : Form
    {
        private string newbalance;
        public CHANGEPIN()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lab 5\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = login.AccNumber;
       private void label13_Click(object sender, EventArgs e)
        {

            if (pin1tb.Text == "" || pin2tb.Text=="")
            {
                MessageBox.Show("enter and confirm the pin");
            }
            else if(pin1tb.Text !=pin2tb.Text){
                MessageBox.Show("pin1 and pin2 are different");
            }
            else
            {

               //newbalance = oldbalance + Convert.ToInt32(depamttb.Text);
                try
                {
                    con.Open();
                    string query = "update AccountTB1 set  PIN=" + pin1tb.Text + " where ACCNUM='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query,con);
                      
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN successfully upated");
                    con.Close();
                    login hOME = new login();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CHANGEPIN_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            this.Hide();
            hOME.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pin1tb_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class con
    {
        internal static void Close()
        {
            throw new NotImplementedException();
        }

        internal static void Open()
        {
            throw new NotImplementedException();
        }
    }
}
