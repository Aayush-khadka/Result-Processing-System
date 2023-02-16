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
            // When class One is Opened Dashbaord is Already Loaded in Panel
            one_form.Controls.Clear();
            dashboard dash = new dashboard() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(dash);
            dash.Show();
            dash.Dock = DockStyle.Fill;
        }

        // Open Form (Class1_data) to Enter Student Data in the Panel
        private void btn_add_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            std_data st_da = new std_data() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(st_da);
            st_da.Show();
            st_da.Dock = DockStyle.Fill;
        }

        //Open From(std_marks_enter) to Enter Marks in the Panel
        public void btn_insert_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            std_marks_enter insert = new std_marks_enter () { TopLevel = false, TopMost = true };
            one_form.Controls.Add(insert);
            insert.Show();
            insert.Dock = DockStyle.Fill;
        }
        // Open From(class1_update) to Update the Data in the Panel
        private void btn_Update_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            Update update = new Update() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(update);
            update.Show();
            update.Dock = DockStyle.Fill;
        }
        // Open the View Form(class1_view) in the Panel
        private void btn_view_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            class1_view view = new class1_view() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(view);
            view.Show();
            view.Dock = DockStyle.Fill;
        }
        // Open the Delete Form (class1_delete)in the Panel
        private void btn_delete_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            class1_delete delete = new class1_delete() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(delete);
            delete.Show();
            delete.Dock = DockStyle.Fill;
        }
        //Open the Print Form(class1_print) in The panel
        private void btn_Print_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            Print print = new Print() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(print);
            print.Show();
            print.Dock = DockStyle.Fill;
        }
        // Return to the Selection Form (Selection)
        private void btn_return_Click(object sender, EventArgs e)
        {
            Selection ret = new Selection();
            this.Hide();
            ret.Show();
        }
        // When Clicked The dashboard Form(dashboard) is Loaded in the Panel
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            one_form.Controls.Clear();
            dashboard dash = new dashboard() { TopLevel = false, TopMost = true };
            one_form.Controls.Add(dash);
            dash.Show();
            dash.Dock = DockStyle.Fill;

        }
        // Exit the Application
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
