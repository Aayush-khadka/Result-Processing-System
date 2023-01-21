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
            
            class1 ab = new class1();
            ab.Show();
            this.Hide();
           
        }

        private void Selection_Load(object sender, EventArgs e)
        {

        }


    }
}
