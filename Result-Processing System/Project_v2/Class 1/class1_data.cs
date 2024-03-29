﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
//Using System.IO;

namespace Project_v2
{
    public partial class std_data : Form
    {
        // satic string path = Path.GetFullPath("database.mdb");
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'");
        public std_data()

        {
            InitializeComponent();
        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {
            string b = date_picker.Text;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            string f_name = txt_fname.Text;
            string l_name = txt_lname.Text;
            string phone = txt_phone.Text;
            string dob = date_picker.Text;
            string age = txt_age.Text;
            string roll = txt_rollno.Text;

            if (f_name != "" && l_name != "" && phone != "" && dob != "" && age != "" && roll != "")
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO Std_Data (Roll_no,f_name,l_name,age,DOB,phone) VALUES('" + roll + "','" + f_name + "','" + l_name + "','" + age + "','" + dob + "','" + phone + "')";
                    cmd.ExecuteNonQuery();
                    txt_fname.Clear();
                    txt_lname.Clear();
                    txt_phone.Clear();
                    date_picker.Text = string.Empty;
                    txt_age.Clear();
                    txt_rollno.Clear();
                    MessageBox.Show("Data Inserted");
                    conn.Close();
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Student with same Roll no already Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fileds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_fname.Clear();
                txt_lname.Clear();
                txt_phone.Clear();
                date_picker.Text = string.Empty;
                txt_age.Clear();
                txt_rollno.Clear();
            }
        }
        private void Validate_num (object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void Validate_txt(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
    }
}
