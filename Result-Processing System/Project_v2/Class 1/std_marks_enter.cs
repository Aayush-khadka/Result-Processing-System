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
    public partial class std_marks_enter : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'");

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

        static int num = 0;

        public std_marks_enter()
        {
            InitializeComponent();
            try
            {

                txt_roll.Text = "0";
                int index = 0;
                string sql = "Select Roll_no,f_name,l_name from Std_Data";
                OleDbCommand cmmd = new OleDbCommand(sql, conn);
                DataSet ds = new DataSet();
                OleDbDataAdapter daa = new OleDbDataAdapter(cmmd);
                daa.Fill(ds);
                txt_roll.Text = ds.Tables[0].Rows[index]["Roll_no"].ToString();
                string first_name = ds.Tables[0].Rows[index]["f_name"].ToString();
                string last_name = ds.Tables[0].Rows[index]["l_name"].ToString();
                lbl_std_name.Text = first_name + " " + last_name;
            }

            catch
            {
                MessageBox.Show("NO Student Data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btn_Enter_Click_1(object sender, EventArgs e)
        {


            try
            {
                int num_maths = int.Parse(txt_maths.Text);
                int num_science = int.Parse(txt_science.Text);
                int num_english = int.Parse(txt_english.Text);
                int num_nepali = int.Parse(txt_nepali.Text);
                int num_social = int.Parse(txt_social.Text);
                int num_gk = int.Parse(txt_gk.Text);
                int num_drawing = int.Parse(txt_drawing.Text);
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
                    int roll = int.Parse(txt_roll.Text);

                    double tot_obtained = (num_english + num_maths + num_nepali + num_science + num_social + num_gk + num_drawing);
                    double Total_gpa;

                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;

                    try
                    {
                        if (maths_grade == "NG" || social_grade == "NG" || nepali_grade == "NG" || english_grade == "NG" || science_grade == "NG" || gk_grade == "NG" || drawing_grade == "NG")
                        {
                            string Total_gpa2 = "NG";
                            cmd.CommandText = "INSERT INTO Class_1 (roll_no,n_maths,n_science,n_nepali,n_english,n_social,n_gk,n_drawing,g_maths,g_science,g_english,g_nepali,g_social,g_drawing,g_gk,gp_maths,gp_science,gp_english,gp_nepali,gp_social,gp_drawing,gp_gk,total_marks,final_gpa,Attendance) values('" + roll + "','" + txt_maths.Text + "','" + txt_science.Text + "','" + txt_nepali.Text + "','" + txt_english.Text + "','" + txt_social.Text + "','" + txt_gk.Text + "','" + txt_drawing.Text + "','" + maths_grade + "','" + science_grade + "','" + english_grade + "','" + nepali_grade + "','" + social_grade + "','" + drawing_grade + "','" + gk_grade + "','" + maths_gpa + "','" + science_gpa + "','" + english_gpa + "','" + nepali_gpa + "','" + social_gpa + "','" + drawing_gpa + "','" + gk_gpa + "','" + tot_obtained + "','" + Total_gpa2 + "','" + txt_Attendance.Text + "')";
                            cmd.ExecuteNonQuery();

                        }

                        else
                        {
                            Total_gpa = gpa_check(tot_obtained);
                            cmd.CommandText = "INSERT INTO Class_1 (roll_no,n_maths,n_science,n_nepali,n_english,n_social,n_gk,n_drawing,g_maths,g_science,g_english,g_nepali,g_social,g_drawing,g_gk,gp_maths,gp_science,gp_english,gp_nepali,gp_social,gp_drawing,gp_gk,total_marks,final_gpa,Attendance) values('" + roll + "','" + txt_maths.Text + "','" + txt_science.Text + "','" + txt_nepali.Text + "','" + txt_english.Text + "','" + txt_social.Text + "','" + txt_gk.Text + "','" + txt_drawing.Text + "','" + maths_grade + "','" + science_grade + "','" + english_grade + "','" + nepali_grade + "','" + social_grade + "','" + drawing_grade + "','" + gk_grade + "','" + maths_gpa + "','" + science_gpa + "','" + english_gpa + "','" + nepali_gpa + "','" + social_gpa + "','" + drawing_gpa + "','" + gk_gpa + "','" + tot_obtained + "','" + Total_gpa + "','" + txt_Attendance.Text + "')";
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Student Data Already Added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_maths.Clear();
                        txt_science.Clear();
                        txt_english.Clear();
                        txt_nepali.Clear();
                        txt_social.Clear();
                        txt_gk.Clear();
                        txt_drawing.Clear();
                        txt_Attendance.Clear();
                        return;
                      
                    }






                    try
                    {
                        num++;

                        int index = num;
                        index = int.Parse(txt_roll.Text);
                        string sql = "Select Roll_no,f_name,l_name from Std_Data";
                        OleDbCommand cmmd = new OleDbCommand(sql, conn);
                        DataSet ds = new DataSet();
                        OleDbDataAdapter daa = new OleDbDataAdapter(cmmd);
                        daa.Fill(ds);
                        txt_roll.Text = ds.Tables[0].Rows[index]["Roll_no"].ToString();
                        string first_name = ds.Tables[0].Rows[index]["f_name"].ToString();
                        string last_name = ds.Tables[0].Rows[index]["l_name"].ToString();
                        lbl_std_name.Text = first_name + " " + last_name;

                        MessageBox.Show("Marks Entered");

                        txt_maths.Clear();
                        txt_science.Clear();
                        txt_english.Clear();
                        txt_nepali.Clear();
                        txt_social.Clear();
                        txt_gk.Clear();
                        txt_drawing.Clear();
                        txt_Attendance.Clear();
                        conn.Close();
                    }

                    catch
                    {
                        MessageBox.Show("Marks of all student Added", "Finshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_maths.Clear();
                        txt_science.Clear();
                        txt_english.Clear();
                        txt_nepali.Clear();
                        txt_social.Clear();
                        txt_gk.Clear();
                        txt_drawing.Clear();
                        txt_roll.Clear();
                        txt_Attendance.Clear();
                        lbl_std_name.Text = "Name";
                        return;

                    }



                }
                else
                {
                    MessageBox.Show("More Marks Inserted than Required", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Fields are Empty", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }






        }

        private void txt_rollno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }

        private void txt_maths_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txt_science_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txt_nepali_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txt_gk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txt_drawing_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txt_social_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }
        private void txt_english_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;
        }

        private void txt_Attendance_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!char.IsDigit(ch) &&
                ch != Convert.ToChar(Keys.Back) &&
                    ch != Convert.ToChar(Keys.Delete))
                e.Handled = true;

        }
    }
}
