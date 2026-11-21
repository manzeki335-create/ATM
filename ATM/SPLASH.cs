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
    public partial class SPLASH : Form
    {
        public SPLASH()
        {
            InitializeComponent();
        }
     

        private void persentlbl_Click(object sender, EventArgs e)
        {

        }
        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting++;
            progressBar1.Value=starting;
            persentlbl.Text=""+starting;
            if (progressBar1.Value == 30) {
                progressBar1.Value = 0;
                Myprogress.Stop();
                login login = new login();  
                this.Hide();
                login.Show();
            }


        }

        private void SPLASH_Load(object sender, EventArgs e)
        {
            Myprogress.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
