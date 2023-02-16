using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_v2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            MaximizeBox = false;
        }
        // Checking Username and Password
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_pass.Text;
            if (username == "admin" && password == "admin")
            {
                Selection ab = new Selection();
                ab.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                txt_pass.Clear();
                txt_user.Clear();
            }
        }
    }
}
