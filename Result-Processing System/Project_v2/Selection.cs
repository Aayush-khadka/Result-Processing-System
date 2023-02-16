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
        //Select Class One
        private void btn_class1_Click(object sender, EventArgs e)
        {
            class1 class1 = new class1();
            class1.Show();
            this.Hide();
        }
    }
}
