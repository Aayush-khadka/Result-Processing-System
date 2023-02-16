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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
        private void btn_View_Click(object sender, EventArgs e)
        {
            Panl_Edit.Controls.Clear();
            Edit_std_data edit = new Edit_std_data() { TopLevel = false, TopMost = true };
            Panl_Edit.Controls.Add(edit);
            edit.Show();
            edit.Dock = DockStyle.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Panl_Edit.Controls.Clear();
            Edit_marks edit = new Edit_marks() { TopLevel = false, TopMost = true };
            Panl_Edit.Controls.Add(edit);
            edit.Show();
            edit.Dock = DockStyle.Fill;
        }
    }
}
