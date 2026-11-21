using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }
        public static string AccNumber;
        private void HOME_Load(object sender, EventArgs e)
        {
          //  accnumberlbl.Text = "Account number :" + login.AccNumber;
            AccNumber = login.AccNumber;
        }

        private void label9_Click(object sender, EventArgs e)
        {
         login log = new login();
            log.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {
          BALANCE bal=new BALANCE();    
            this.Hide();
            bal.Show();
            
        }

       private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
         CHANGEPIN PIN=new CHANGEPIN();
            PIN.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
          WITHDRAW WD=new WITHDRAW();   
            WD.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FAST_CASH FCASH=new FAST_CASH();
            FCASH.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MINISTATMENT m=new MINISTATMENT();
            m.Show();
            this.Hide();
        }

        private void accnumberlbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            DEPOSIT Dep = new DEPOSIT();
            Dep.Show();
            this.Hide();
        }
    }
}
