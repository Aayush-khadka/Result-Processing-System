using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Project_v2
{
    public partial class std_data : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'");
        public std_data()

        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            string f_name = txt_fname.Text;
            string l_name = txt_lname.Text;
            string phone = txt_phone.Text;
            string dob = txt_dob.Text;
            string age = txt_age.Text;
            string roll = txt_rollno.Text;
            conn.Open();

            cmd.CommandText = "INSERT INTO Std_Data (Roll_no,f_name,l_name,age,DOB,phone) VALUES('" + roll + "','" + f_name + "','" + l_name + "','" + age + "','" + dob + "','" + phone + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO class_1 (roll_no) VALUES('" + roll + "')";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Data Inserted");
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
            conn.Close();

        }

        private void std_data_Load(object sender, EventArgs e)
        {

        }

    }
}
