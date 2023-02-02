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
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'");

        public class1_delete()
        {
            InitializeComponent();
        }

        private void btn_Delete_data_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Delete the row", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                int roll = int.Parse(txt_roll.Text);
                cmd.CommandText = "Delete from Std_Data where Roll_no='" + roll + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                conn.Close();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Delete the row", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                int roll = int.Parse(txt_num.Text);
                cmd.CommandText = "Delete from Std_Data where roll_no='" + roll + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted","Deleted");
                conn.Close();
            }
        }



    }
}
