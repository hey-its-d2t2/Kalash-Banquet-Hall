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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PasswordResetFrm rp =new   PasswordResetFrm();
            rp.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MainFrm mf =new MainFrm();
            mf.Show();
            this.Hide();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtUId.Text = "";
            TxtPass.Text = "";
        }

        private void LblForgotPassword_MouseHover(object sender, EventArgs e)
        {
            LblForgotPassword.ForeColor = Color.FromArgb(245, 99, 24);
        }

        private void LblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            LblForgotPassword.ForeColor = Color.FromArgb(83, 12, 13);
        }
    }
}
