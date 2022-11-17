using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalash_Banquet_Hall
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            CircleProgressBar1.Text = "";
            CircleProgressBar1.Value = 0;
            CircleProgressBar1.ForeColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CircleProgressBar1.Value += 20;
            if(CircleProgressBar1.Value == 100)
            {
                timer1.Enabled = false;  
               LoginForm lf = new LoginForm();
                this.Hide();
                lf.Show();
            }
        }
    }
}
