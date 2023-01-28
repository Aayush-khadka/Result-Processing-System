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
    public partial class Insert_class1 : Form
    {
        OleDbConnection conn = new OleDbConnection();



        public static string grade_check(int z)
        {
            if (z >= 90)
            {
                string a = "A+";
                return a;
            }
            else if (z>= 80 && z <90 )
            {
                string b = "A";
                    return b;
            }

            else if (z >= 70 && z < 80 )
            {
                string b = "B+";
                return b;
            }
            else if (z >=  60 && z < 70 )
            {
                string b = "B";
                return b;
            }
            else if (z >= 50 && z < 60 )
            {
                string b = "C+";
                return b;
            }
            else if (z >= 40 && z < 50)
            {
                string b = "C";
                return b;
            }
            else if (z >= 30 && z < 40 )
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


        public static string grade_check50(int z)
        {
            if (z >= 45)
            {
                string a = "A+";
                return a;
            }
            else if (z >= 40 && z < 45)
            {
                string b = "A";
                return b;
            }

            else if (z >= 35 && z < 40)
            {
                string b = "B+";
                return b;
            }
            else if (z >= 30 && z < 35)
            {
                string b = "B";
                return b;
            }
            else if (z >= 25 && z < 30)
            {
                string b = "C+";
                return b;
            }
            else if (z >= 20 && z < 25)
            {
                string b = "C";
                return b;
            }
            else if (z >= 15 && z < 20)
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




        public static double  sub_gpa(string j)
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
                double f= 2.0;
                return f;
            }

            else if (j == "D")
            {
                double g = 1.6;
                return g;
            }

            else
                
                return 0;
        }



        public static double gpa_check(double i)
        {

            double percentage = (i / 600) * 100;
            double gpa = (percentage / 100) * 4;
            double r_gpa = Math.Round(gpa, 2);
            return r_gpa;

        }

        public Insert_class1()
        {
            InitializeComponent();

            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'";
        }

        private void button1_Click(object sender, EventArgs e)
        {


            conn.Open();

            int num_maths = int.Parse(txt_maths.Text);
            int num_science = int.Parse(txt_science.Text);
            int num_english = int.Parse(txt_english.Text);
            int num_nepali = int.Parse(txt_nepali.Text);
            int num_social = int.Parse(txt_social.Text);
            int num_gk = int.Parse(txt_gk.Text);
            int num_drawing = int.Parse(txt_drawing.Text);


            string maths_grade= grade_check(num_maths);
            string social_grade = grade_check(num_social);
            string nepali_grade = grade_check(num_nepali);
            string english_grade = grade_check(num_english);
            string science_grade = grade_check(num_science);
            string gk_grade = grade_check50(num_gk);
            string drawing_grade = grade_check50(num_drawing);

            double maths_gpa = sub_gpa(maths_grade);
            double social_gpa = sub_gpa(social_grade);
            double nepali_gpa = sub_gpa(nepali_grade);
            double english_gpa = sub_gpa(english_grade);
            double science_gpa = sub_gpa(science_grade);
            double gk_gpa = sub_gpa(gk_grade);
            double drawing_gpa = sub_gpa(drawing_grade);

            double tot_obtained = (num_english + num_maths + num_nepali + num_science + num_social + num_gk + num_drawing);


            



           


            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;

                         double Total_gpa;
           

            if (maths_grade=="NG" || social_grade=="NG" || nepali_grade=="NG"||english_grade=="NG"||science_grade=="NG"||gk_grade=="NG"||drawing_grade=="NG")
            {
                string Total_gpa2= "NG";
                cmd.CommandText = "INSERT INTO Class_1 (roll_no,F_name,L_name,n_maths,n_science,n_nepali,n_english,n_social,n_gk,n_drawing,g_maths,g_science,g_english,g_nepali,g_social,g_drawing,g_gk,gpa_maths,gpa_science,gpa_english,gpa_nepali,gpa_social,gpa_drawing,gpa_gk,total_marks,final_gpa,Attendance) values('" + txt_rnum.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_maths.Text + "','" + txt_science.Text + "','" + txt_nepali.Text + "','" + txt_english.Text + "','" + txt_social.Text + "','" + txt_gk.Text + "','" + txt_drawing.Text + "','" + maths_grade + "','" + science_grade + "','" + english_grade + "','" + nepali_grade + "','" + social_grade + "','" + drawing_grade + "','" + gk_grade + "','" + maths_gpa + "','" + science_gpa + "','" + english_gpa + "','" + nepali_gpa + "','" + social_gpa + "','" + drawing_gpa + "','" + gk_gpa + "','" + tot_obtained + "','" + Total_gpa2 + "','" + txt_Attendance.Text + "')";
                cmd.ExecuteNonQuery();
                
            }
            else {
                Total_gpa = gpa_check(tot_obtained);
                cmd.CommandText = "INSERT INTO Class_1 (roll_no,F_name,L_name,n_maths,n_science,n_nepali,n_english,n_social,n_gk,n_drawing,g_maths,g_science,g_english,g_nepali,g_social,g_drawing,g_gk,gpa_maths,gpa_science,gpa_english,gpa_nepali,gpa_social,gpa_drawing,gpa_gk,total_marks,final_gpa,Attendance) values('" + txt_rnum.Text + "','" + txt_fname.Text + "','" + txt_lname.Text + "','" + txt_maths.Text + "','" + txt_science.Text + "','" + txt_nepali.Text + "','" + txt_english.Text + "','" + txt_social.Text + "','" + txt_gk.Text + "','" + txt_drawing.Text + "','" + maths_grade + "','" + science_grade + "','" + english_grade + "','" + nepali_grade + "','" + social_grade + "','" + drawing_grade + "','" + gk_grade + "','" + maths_gpa + "','" + science_gpa + "','" + english_gpa + "','" + nepali_gpa + "','" + social_gpa + "','" + drawing_gpa + "','" + gk_gpa + "','" + tot_obtained + "','" + Total_gpa + "','" + txt_Attendance.Text + "')";
                cmd.ExecuteNonQuery();
            }







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

            string query = "select * from Class_1";
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_view.DataSource = dt;


           
            conn.Close();





        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            string query = "select * from Class_1";
            cmd.CommandText = query;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_view.DataSource = dt;



            conn.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Insert_class1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }






        










    }
}
