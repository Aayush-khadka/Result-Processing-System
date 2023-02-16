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
    public partial class class1_delete : Form
    {
        // Database Connection
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'");

        public class1_delete()
        {
            InitializeComponent();
        }

        //Delete Data from Student Data Table
        private void button1_Click(object sender, EventArgs e)
        {
            // Checking if the Rollno  textbox is Empty
            if (txt_roll.Text != "")
            {
                // Asking if you are Sure you want to Delete the Record 
                DialogResult result = MessageBox.Show("Do you want to Delete the Record ", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
               // If the result is YES the Row of the Entered Rollno is Deleted
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    int roll = int.Parse(txt_roll.Text);
                    cmd.CommandText = "Delete from Std_Data where Roll_no='" + roll + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_roll.Clear();
                    conn.Close(); 
                }
            }
            // Informing User about the Empty Field
            else
            {
                MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // Delete Data From Student Marks Table 
        private void button2_Click(object sender, EventArgs e)
        {
            // Checking if the Rollno  textbox is Empty
             if (txt_num.Text!="")
            {
                // Asking if you are Sure you want to Delete the Record 
                DialogResult result = MessageBox.Show("Do you want to Delete the row", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                // If the result is YES the Row of the Entered Rollno is Deleted
                 if (result == DialogResult.Yes)
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();

                    int roll = int.Parse(txt_num.Text);
                    cmd.Connection = conn;
                    cmd.CommandText = "Delete from Class_1 where roll_no=" + roll + "";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_num.Clear();
                    conn.Close();
                }
            }
             // Informing User about the Empty Field
            else
             {
                 MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
        }
        // Cleaning the Whole Student Record Database
        private void button3_Click(object sender, EventArgs e)
        {
            // Asking if the user is sure to Clean the Database
            DialogResult result = MessageBox.Show("Do you want to clean the Database?","ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            // If the Answer is YEst the Database is Cleaned
            if (result == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from Std_Data";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database Emptyed", "Emptyed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }
        // Cleaning the Whole Student Marks Record Database
        private void button4_Click(object sender, EventArgs e)
        {
            // Asking if the user is sure to Clean the Database
            DialogResult result = MessageBox.Show("Do you want to clean the Database?","ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            // If the Answer is YEst the Database is Cleaned
            if (result == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from Class_1";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Database Emptyed", "Emptyed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }
        // Valaditing the User input so, only numbers are accepted
        private void Validate_num (object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
    }
}

