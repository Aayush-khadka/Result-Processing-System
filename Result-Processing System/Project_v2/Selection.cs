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
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void btn_class1_Click(object sender, EventArgs e)
        {
            class1 class1 = new class1();
            class1.Show();
            this.Hide();  
        }

        private void btn_class2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Development");
        }

        private void btn_class3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Development");
        }

        private void btn_class4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Development");
        }

        private void btn_class5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Development");
        }
    }
}
