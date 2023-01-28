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
    public partial class Insert_Class_One : Form
    {
       
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'");
        OleDbCommand cmd = new OleDbCommand();
        
        public Insert_Class_One()
        {      
            InitializeComponent();
        }

        public static string Sub_grade_check(int z)
        {
            if (z >= 90)
            {
                string a = "A+";
                return a;
            }
            else if (z >= 80 && z < 90)
            {
                string b = "A";
                return b;
            }

            else if (z >= 70 && z < 80)
            {
                string b = "B+";
                return b;
            }
            else if (z >= 60 && z < 70)
            {
                string b = "B";
                return b;
            }
            else if (z >= 50 && z < 60)
            {
                string b = "C+";
                return b;
            }
            else if (z >= 40 && z < 50)
            {
                string b = "C";
                return b;
            }
            else if (z >= 30 && z < 40)
            {
                string b = "D";
                return b;
            }
            else
            {
                string n = "NG";
                return n;
            }
        }

        public static double sub_gp_check(string j)
        {
            if (j == "A+")
            {
                double a = 4.0;
                return a;
            }
            else if (j == "A")
            {
                double b = 3.6;
                return b;
            }
            else if (j == "B+")
            {
                double c = 3.2;
                return c;
            }
            else if (j == "B")
            {
                double d = 2.8;
                return d;
            }
            else if (j == "C+")
            {
                double e = 2.4;
                return e;
            }
            else if (j == "C")
            {
                double f = 2.0;
                return f;
            }
            else if (j == "D")
            {
                double g = 1.6;
                return g;
            }
            else return 0;
        }

        public  void maths()
            {
                cmd.Connection = conn;
                conn.Open();
                int marks=int.Parse(txt_marks.Text);
                string grade= Sub_grade_check(marks);
                double gp = sub_gp_check(grade);
                int roll = int.Parse(lbl_num.Text);
                cmd.CommandText = "INSERT INTO Class_1 (n_maths,g_maths,gp_maths,roll_no) VALUES('" + marks + "','" + grade + "','" + gp + "','" + roll + "')";
                cmd.ExecuteNonQuery();
                txt_marks.Clear();
                conn.Close();   
             }

        public void science()
        {
            cmd.Connection = conn;
            conn.Open();
            int marks=int.Parse(txt_marks.Text);
            string grade= Sub_grade_check(marks);
            double gp = sub_gp_check(grade);
            string roll = lbl_num.Text;
            cmd.CommandText = @"Update Class_1 SET n_science =@marks,g_science=@grade,gp_science=@gp where roll_no=@roll" ;
            cmd.Parameters.AddWithValue("@marks",marks);
            cmd.Parameters.AddWithValue("@grade",grade);
            cmd.Parameters.AddWithValue("@gp",gp);
            cmd.Parameters.AddWithValue("@roll",roll);
            cmd.ExecuteNonQuery();
            conn.Close();
            txt_marks.Clear();
        }

        static int num = 0;
        private void btn_s_zero_Click(object sender, EventArgs e)
        {
            num = 0;
        }

        private  void btn_Submit_Click(object sender, EventArgs e)
        {
            string subject = combo_Subject.Text;
            
            if (subject=="Maths")
            {  
                maths();
                conn.Open();
                cmd.Connection = conn;
                string query = "select roll_no,n_maths from Class_1";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_View.DataSource = dt;
                conn.Close();
            }

            else if(subject=="Science")
            {
                science();
                conn.Open();
                cmd.Connection = conn;
                string query = "select roll_no,n_science from Class_1";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Data_View.DataSource = dt;
                conn.Close();
            }

            num++;
            int index = num;
            string sql = "Select Roll_no,f_name,l_name from Std_Data";
            OleDbCommand cmmd = new OleDbCommand(sql, conn);
            DataSet ds = new DataSet();
            OleDbDataAdapter daa = new OleDbDataAdapter(cmmd);
            daa.Fill(ds);
            lbl_num.Text = ds.Tables[0].Rows[index]["Roll_no"].ToString();
            string first_name = ds.Tables[0].Rows[index]["f_name"].ToString();
            string last_name = ds.Tables[0].Rows[index]["l_name"].ToString();
            lbl_std_name.Text = first_name + " " + last_name;
            
        }

        private void combo_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            string sql = "Select Roll_no,f_name,l_name from Std_Data";
            OleDbCommand cmmd = new OleDbCommand(sql, conn);
            DataSet ds = new DataSet();
            OleDbDataAdapter daa = new OleDbDataAdapter(cmmd);
            daa.Fill(ds);
            lbl_num.Text = ds.Tables[0].Rows[count]["Roll_no"].ToString();
            string first_name = ds.Tables[0].Rows[count]["f_name"].ToString();
            string last_name = ds.Tables[0].Rows[count]["l_name"].ToString();
            lbl_std_name.Text = first_name + " " + last_name;

        }
    }
}
