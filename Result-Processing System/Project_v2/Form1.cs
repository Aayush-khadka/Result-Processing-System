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
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_user.Text;
            string password = txt_pass.Text;
            if (username == "Aayush" && password == "Aayush123")
            {
                
                Selection ab = new Selection();
                ab.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                txt_pass.Clear();
                txt_user.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
