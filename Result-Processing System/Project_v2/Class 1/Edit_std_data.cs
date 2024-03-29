﻿using System;
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
    public partial class Edit_std_data : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'");
        OleDbCommand cmd = new OleDbCommand();
        public Edit_std_data()
        {
            InitializeComponent();

        }
        //Selecting Student data from Database
        private void btn_retrive_Click(object sender, EventArgs e)
        {
            if (txt_rollno.Text != "")
            {
                string sql = "Select * from Std_Data";
                OleDbCommand cmmd = new OleDbCommand(sql, conn);
                DataSet ds = new DataSet();
                OleDbDataAdapter daa = new OleDbDataAdapter(cmmd);
                daa.Fill(ds);
                int a = ds.Tables[0].Rows.Count;
                int num = int.Parse(txt_rollno.Text);
                int roll = num - 1;
                if (num <= a)
                {
                    txt_fname.Text = ds.Tables[0].Rows[roll]["f_name"].ToString();
                    txt_lname.Text = ds.Tables[0].Rows[roll]["l_name"].ToString();
                    txt_age.Text = ds.Tables[0].Rows[roll]["age"].ToString();
                    txt_phone.Text = ds.Tables[0].Rows[roll]["phone"].ToString();
                    txt_dob.Text = ds.Tables[0].Rows[roll]["DOB"].ToString();
                }
                else
                {
                    MessageBox.Show("Unable to find Roll no ' " + txt_rollno.Text + " '", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // UPdating the Student Data
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_age.Text != "" && txt_phone.Text != "" && txt_fname.Text != "" && txt_lname.Text != "")
            {
                int num = int.Parse(txt_rollno.Text);
                int roll = num;
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = @"Update Std_Data SET f_name =@fname,l_name=@lname,age=@age,DOB=@dob,phone=@phone where roll_no=@roll";
                cmd.Parameters.AddWithValue("@fname", txt_fname.Text);
                cmd.Parameters.AddWithValue("@lname", txt_lname.Text);
                cmd.Parameters.AddWithValue("@age", txt_age.Text);
                cmd.Parameters.AddWithValue("@dob", txt_dob.Text);
                cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
                cmd.Parameters.AddWithValue("@roll", roll);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Updated");
                txt_rollno.Clear();
                txt_fname.Clear();
                txt_lname.Clear();
                txt_age.Clear();
                txt_phone.Clear();
                txt_dob.Clear();
            }
            else
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Validate_num(object sender, KeyPressEventArgs e)
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
