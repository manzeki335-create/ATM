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
    public partial class ACCOUNT : Form
    {
        public ACCOUNT()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lab 5\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
 private void ACCOUNT_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            int don = 0;
            if (AccNameTB.Text == "" || AccNumTB.Text == "" || FnameTB.Text == "" || AddressTB.Text == "" || PhoneTB.Text == "" || PinTB.Text == ""  || OccupationTB.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                 con.Open();
                    string query = "insert into AccountTB1 values('" + AccNumTB.Text + "','" + AccNameTB.Text + "','" + FnameTB.Text + "','" + dateTimePicker1.Value.Date + "','" + PhoneTB.Text + "','" + AddressTB.Text + "','" + EducationCB.SelectedItem.ToString() + "','" + OccupationTB.Text + "','" + PinTB.Text + "',"+don+") ";
                    SqlCommand cmd = new SqlCommand(query,con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully");
                    con.Close();
                    login log = new login();
                    log.Show();
                    this.Hide();
                }catch (Exception EX){
                    MessageBox.Show(EX.Message);
                
                }
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
