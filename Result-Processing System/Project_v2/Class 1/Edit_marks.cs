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
    public partial class Edit_marks : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'");
        OleDbCommand cmd = new OleDbCommand();
        public Edit_marks()
        {
            InitializeComponent();
        }
        public static string grade_check(int z)
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

        public static double sub_gpa(string j)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_rollno.Text!="")
            {
                string sql = "Select * from Class_1";
                OleDbCommand cmmd = new OleDbCommand(sql, conn);
                DataSet ds = new DataSet();
                OleDbDataAdapter daa = new OleDbDataAdapter(cmmd);
                daa.Fill(ds);
                int a = ds.Tables[0].Rows.Count;
                int num = int.Parse(txt_rollno.Text);
                int roll = num - 1;

                if (num <= a)
                {
                    txt_english.Text = ds.Tables[0].Rows[roll]["n_english"].ToString();
                    txt_social.Text = ds.Tables[0].Rows[roll]["n_social"].ToString();
                    txt_nepali.Text = ds.Tables[0].Rows[roll]["n_nepali"].ToString();
                    txt_gk.Text = ds.Tables[0].Rows[roll]["n_gk"].ToString();
                    txt_drawing.Text = ds.Tables[0].Rows[roll]["n_drawing"].ToString();
                    txt_science.Text = ds.Tables[0].Rows[roll]["n_science"].ToString();
                    txt_maths.Text = ds.Tables[0].Rows[roll]["n_maths"].ToString();
                    txt_Attendance.Text = ds.Tables[0].Rows[roll]["Attendance"].ToString();
                }
                else
                {
                    MessageBox.Show("Unable to find Roll no ' " + txt_rollno.Text + " '", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else
            {
                MessageBox.Show("Empty Fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_english.Text != "" && txt_maths.Text != "" && txt_nepali.Text != "" && txt_science.Text != "" && txt_social.Text != "" && txt_drawing.Text != "")
            {
                int num_maths = int.Parse(txt_maths.Text);
                int num_science = int.Parse(txt_science.Text);
                int num_english = int.Parse(txt_english.Text);
                int num_nepali = int.Parse(txt_nepali.Text);
                int num_social = int.Parse(txt_social.Text);
                int num_gk = int.Parse(txt_gk.Text);
                int num_drawing = int.Parse(txt_drawing.Text);

                int Attendance = int.Parse(txt_Attendance.Text);



                if (num_maths < 100 && num_science < 100 && num_english < 100 && num_nepali < 100 && num_social < 100 && num_gk < 50 && num_drawing < 50)
                {
                    string maths_grade = grade_check(num_maths);
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
                    double Total_gpa;
                    Total_gpa = gpa_check(tot_obtained);

                    int num = int.Parse(txt_rollno.Text);
                    int roll = num;

                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;


                    if (maths_grade == "NG" || social_grade == "NG" || nepali_grade == "NG" || english_grade == "NG" || science_grade == "NG" || gk_grade == "NG" || drawing_grade == "NG")
                    {
                        string Total_gpa2 = "NG";
                        cmd.CommandText = @"Update Class_1 SET n_maths =@n_maths,g_maths=@g_maths,gp_maths=@gp_maths,n_science =@n_science,g_science=@g_science,gp_science=@gp_science,n_english=@n_english,g_english=@g_english,gp_english=@gp_english,n_nepali=@n_nepali,g_nepali=@g_nepali,gp_nepali=@gp_nepali,n_social=@n_social,g_social=@g_social,gp_social=@gp_social,n_drawing=@n_drawing,g_drawing=@g_drawing,gp_drawing=@gp_drawing,n_gk=@n_gk,g_gk=@g_gk,gp_gk=@gp_gk,total_marks=@total_marks,final_gpa=@final_gpa,Attendance=@Attendance where roll_no=@roll";
                        cmd.Parameters.AddWithValue("@n_maths", num_maths);
                        cmd.Parameters.AddWithValue("@g_maths", maths_grade);
                        cmd.Parameters.AddWithValue("@gp_maths", maths_gpa);

                        cmd.Parameters.AddWithValue("@n_science", num_science);
                        cmd.Parameters.AddWithValue("@g_science", science_grade);
                        cmd.Parameters.AddWithValue("@gp_science", science_gpa);

                        cmd.Parameters.AddWithValue("@n_english", num_english);
                        cmd.Parameters.AddWithValue("@g_english", english_grade);
                        cmd.Parameters.AddWithValue("@gp_english", english_gpa);

                        cmd.Parameters.AddWithValue("@n_nepali", num_nepali);
                        cmd.Parameters.AddWithValue("@g_nepali", nepali_grade);
                        cmd.Parameters.AddWithValue("@gp_nepali", nepali_gpa);

                        cmd.Parameters.AddWithValue("@n_social", num_social);
                        cmd.Parameters.AddWithValue("@g_social", social_grade);
                        cmd.Parameters.AddWithValue("@gp_social", social_gpa);

                        cmd.Parameters.AddWithValue("@n_drawing", num_drawing);
                        cmd.Parameters.AddWithValue("@g_drawing", drawing_grade);
                        cmd.Parameters.AddWithValue("@gp_drawing", drawing_gpa);

                        cmd.Parameters.AddWithValue("@n_gk", num_gk);
                        cmd.Parameters.AddWithValue("@g_gk", gk_grade);
                        cmd.Parameters.AddWithValue("@gp_gk", gk_gpa);

                        cmd.Parameters.AddWithValue("total_marks", tot_obtained);
                        cmd.Parameters.AddWithValue("@final_gpa", Total_gpa2);
                        cmd.Parameters.AddWithValue("@Attendance", Attendance);
                        cmd.Parameters.AddWithValue("@roll", roll);
                        cmd.ExecuteNonQuery();

                    }

                    else
                    {
                        cmd.CommandText = @"Update Class_1 SET n_maths =@n_maths,g_maths=@g_maths,gp_maths=@gp_maths,n_science =@n_science,g_science=@g_science,gp_science=@gp_science,n_english=@n_english,g_english=@g_english,gp_english=@gp_english,n_nepali=@n_nepali,g_nepali=@g_nepali,gp_nepali=@gp_nepali,n_social=@n_social,g_social=@g_social,gp_social=@gp_social,n_drawing=@n_drawing,g_drawing=@g_drawing,gp_drawing=@gp_drawing,n_gk=@n_gk,g_gk=@g_gk,gp_gk=@gp_gk,total_marks=@total_marks,final_gpa=@final_gpa,Attendance=@Attendance where roll_no=@roll";
                        cmd.Parameters.AddWithValue("@n_maths", num_maths);
                        cmd.Parameters.AddWithValue("@g_maths", maths_grade);
                        cmd.Parameters.AddWithValue("@gp_maths", maths_gpa);

                        cmd.Parameters.AddWithValue("@n_science", num_science);
                        cmd.Parameters.AddWithValue("@g_science", science_grade);
                        cmd.Parameters.AddWithValue("@gp_science", science_gpa);

                        cmd.Parameters.AddWithValue("@n_english", num_english);
                        cmd.Parameters.AddWithValue("@g_english", english_grade);
                        cmd.Parameters.AddWithValue("@gp_english", english_gpa);

                        cmd.Parameters.AddWithValue("@n_nepali", num_nepali);
                        cmd.Parameters.AddWithValue("@g_nepali", nepali_grade);
                        cmd.Parameters.AddWithValue("@gp_nepali", nepali_gpa);

                        cmd.Parameters.AddWithValue("@n_social", num_social);
                        cmd.Parameters.AddWithValue("@g_social", social_grade);
                        cmd.Parameters.AddWithValue("@gp_social", social_gpa);

                        cmd.Parameters.AddWithValue("@n_drawing", num_drawing);
                        cmd.Parameters.AddWithValue("@g_drawing", drawing_grade);
                        cmd.Parameters.AddWithValue("@gp_drawing", drawing_gpa);

                        cmd.Parameters.AddWithValue("@n_gk", num_gk);
                        cmd.Parameters.AddWithValue("@g_gk", gk_grade);
                        cmd.Parameters.AddWithValue("@gp_gk", gk_gpa);

                        cmd.Parameters.AddWithValue("total_marks", tot_obtained);
                        cmd.Parameters.AddWithValue("@final_gpa", Total_gpa);
                        cmd.Parameters.AddWithValue("@Attendance", Attendance);
                        cmd.Parameters.AddWithValue("@roll", roll);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    MessageBox.Show("Data Updated:");
                    txt_maths.Clear();
                    txt_science.Clear();
                    txt_english.Clear();
                    txt_nepali.Clear();
                    txt_social.Clear();
                    txt_gk.Clear();
                    txt_drawing.Clear();
                    txt_Attendance.Clear();
                }
            }

            else
            {
                MessageBox.Show("Empty Fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }

    }
}
