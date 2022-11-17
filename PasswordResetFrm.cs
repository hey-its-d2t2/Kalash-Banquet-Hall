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
    public partial class PasswordResetFrm : Form
    {
        public PasswordResetFrm()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtPassReType.Text = "";
            TxtPassword.Text = "";
            TxtProductKey.Text = "";
            TxtUID.Text = "";
        }
    }
}
