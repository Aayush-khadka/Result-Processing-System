using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Project_v2
{
    public partial class class1 : Form
    {
        public class1()
        {
            InitializeComponent();
            one_form.Controls.Clear();
            dashboard dash = new dashboard() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(dash);
            dash.Show();
            dash.Dock = DockStyle.Fill;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            std_data st_da = new std_data() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(st_da);
            st_da.Show();
            st_da.Dock = DockStyle.Fill;
        }

        public void btn_insert_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            std_marks_enter insert = new std_marks_enter () { TopLevel = false, TopMost = true };
            one_form.Controls.Add(insert);
            insert.Show();
            insert.Dock = DockStyle.Fill;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            Update update = new Update() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(update);
            update.Show();
            update.Dock = DockStyle.Fill;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            class1_view view = new class1_view() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(view);
            view.Show();
            view.Dock = DockStyle.Fill;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            class1_delete delete = new class1_delete() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(delete);
            delete.Show();
            delete.Dock = DockStyle.Fill;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            Print print = new Print() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(print);
            print.Show();
            print.Dock = DockStyle.Fill;
        }
        
        private void btn_return_Click(object sender, EventArgs e)
        {
            Selection ret = new Selection();
            this.Hide();
            ret.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            dashboard dash = new dashboard() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(dash);
            dash.Show();
            dash.Dock = DockStyle.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
