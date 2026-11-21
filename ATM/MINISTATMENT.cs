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
    public partial class MINISTATMENT : Form
    {
        public MINISTATMENT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lab 5\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = login.AccNumber;
        private void populate()
        {
            con.Open();
            string query = "select * from TransactionTB1 where AccNum='" + Acc + "'";
            SqlDataAdapter sd=new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sd);
            var ds= new DataSet();
            sd.Fill(ds);
            ministatementdgv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void MINISTATMENT_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            this.Hide();
            hOME.Show();
        }
    }
}
