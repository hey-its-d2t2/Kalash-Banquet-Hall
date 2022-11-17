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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PnlTitle_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PnlTitle_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                if (BtnsPanel.Width == 230)
                {
                    BtnsPanel.Width = 70;
                    BtnMenuColapse.Rotate(180);

                }
                else if (BtnsPanel.Width == 70)
                {

                    BtnsPanel.Width = 230;
                    BtnMenuColapse.Rotate(0);
                }
                else
                {
                    BtnsPanel.Width = 70;
                    BtnMenuColapse.Rotate(180);
                }
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                if (BtnsPanel.Width == 230)
                {
                    BtnsPanel.Width = 70;
                    BtnMenuColapse.Rotate(180);
                }
                else if (BtnsPanel.Width == 70)
                {
                    BtnsPanel.Width = 230;
                    BtnMenuColapse.Rotate(0);
                }
                else
                {
                    BtnsPanel.Width = 70;
                    BtnMenuColapse.Rotate(180);
                }
            }

        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                if (BtnsPanel.Width == 230)
                {
                    BtnsPanel.Width = 70;
                    BtnMenuColapse.Rotate(180);
                }
                else if (BtnsPanel.Width == 70)
                {
                    BtnsPanel.Width = 230;
                    BtnMenuColapse.Rotate(0);
                }
                else
                {
                    BtnsPanel.Width = 70;
                    BtnMenuColapse.Rotate(180);
                }
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                if (BtnsPanel.Width == 230)
                {
                    BtnsPanel.Width = 70;
                    BtnMenuColapse.Rotate(180);
                }
                else if (BtnsPanel.Width == 70)
                {

                    BtnsPanel.Width = 230;
                    BtnMenuColapse.Rotate(0);
                }
                else
                {
                    BtnsPanel.Width = 70;
                    BtnMenuColapse.Rotate(180);
                }
            }

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenuColapse_Click(object sender, EventArgs e)
        {
            if (BtnsPanel.Width == 230)
            {
                BtnsPanel.Width = 70;
                BtnMenuColapse.Rotate(180);
            }
            else if (BtnsPanel.Width == 70)
            {
                BtnsPanel.Width = 230;
                BtnMenuColapse.Rotate(0);
            }
            else
            {
                BtnsPanel.Width = 70;
                BtnMenuColapse.Rotate(180);
            }
        }
     

        

        private void BtnFrontDesk_Click(object sender, EventArgs e)
        {
            BtnSli.Top = BtnFrontDesk.Top;
            BtnSli.Height = BtnFrontDesk.Height;
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            BtnSli.Top = BtnContact.Top;
            BtnSli.Height = BtnContact.Height;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            BtnSli.Top = BtnReport.Top;
            BtnSli.Height = BtnReport.Height;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            BtnSli.Top = BtnAdmin.Top;
            BtnSli.Height = BtnAdmin.Height;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            BtnSli.Top = BtnHome.Top;
            BtnSli.Height = BtnHome.Height;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}
