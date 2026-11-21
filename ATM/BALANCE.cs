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
    public partial class BALANCE : Form
    {
        public BALANCE()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lab 5\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        private void getbalance() {
        con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select BALANCE from AccountTB1 where ACCNUM='" + ACCNUMLBL.Text + "'", con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            balancelbl.Text ="Rs"+ dt.Rows[0][0].ToString();
            con.Close();
        }
        private void BALANCE_Load(object sender, EventArgs e)
        {
          ACCNUMLBL.Text=HOME.AccNumber;
            getbalance();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            this.Hide();
            hOME.Show();
        }

        private void balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
