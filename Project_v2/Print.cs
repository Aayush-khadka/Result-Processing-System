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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        private void Print_Load(object sender, EventArgs e)
        {
            string qur = "Select * from Class_1";
            conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Database\Database.mdb'");
            cmd = new OleDbCommand(qur, conn);
            da = new OleDbDataAdapter(cmd);
            da.Fill(ds);
        }



        private void btn_res_Print_Click(object sender, EventArgs e)
        {

            int index;
            int a = int.Parse(txt_no_std.Text);

            for (index = 0; index < a; index++)
            {



                string roll_no = ds.Tables[0].Rows[index]["roll_no"].ToString();
                string F_name = ds.Tables[0].Rows[index]["F_name"].ToString();
                string L_name = ds.Tables[0].Rows[index]["L_name"].ToString();

                string m_science = ds.Tables[0].Rows[index]["n_science"].ToString();
                string m_english = ds.Tables[0].Rows[index]["n_english"].ToString();
                string m_nepali = ds.Tables[0].Rows[index]["n_nepali"].ToString();
                string m_maths = ds.Tables[0].Rows[index]["n_maths"].ToString();
                string m_gk = ds.Tables[0].Rows[index]["n_gk"].ToString();
                string m_drawing = ds.Tables[0].Rows[index]["n_drawing"].ToString();
                string m_social = ds.Tables[0].Rows[index]["n_social"].ToString();

                string g_science = ds.Tables[0].Rows[index]["g_science"].ToString();
                string g_english = ds.Tables[0].Rows[index]["g_english"].ToString();
                string g_nepali = ds.Tables[0].Rows[index]["g_nepali"].ToString();
                string g_maths = ds.Tables[0].Rows[index]["g_maths"].ToString();
                string g_gk = ds.Tables[0].Rows[index]["g_gk"].ToString();
                string g_drawing = ds.Tables[0].Rows[index]["g_drawing"].ToString();
                string g_social = ds.Tables[0].Rows[index]["g_social"].ToString();


                string gpa_science = ds.Tables[0].Rows[index]["gpa_science"].ToString();
                string gpa_english = ds.Tables[0].Rows[index]["gpa_english"].ToString();
                string gpa_nepali = ds.Tables[0].Rows[index]["gpa_nepali"].ToString();
                string gpa_maths = ds.Tables[0].Rows[index]["gpa_maths"].ToString();
                string gpa_gk = ds.Tables[0].Rows[index]["gpa_gk"].ToString();
                string gpa_drawing = ds.Tables[0].Rows[index]["gpa_drawing"].ToString();
                string gpa_social = ds.Tables[0].Rows[index]["gpa_social"].ToString();

                string t_gpa = ds.Tables[0].Rows[index]["final_gpa"].ToString();
                string attend = ds.Tables[0].Rows[index]["Attendance"].ToString();




                var application = new Microsoft.Office.Interop.Word.Application();
                var document = new Microsoft.Office.Interop.Word.Document();

                document = application.Documents.Add(Template: @"C:\Users\Aayush\Desktop\c# project\Project_v2\Report-Card_Format\Report-Card.docx");


                foreach (Microsoft.Office.Interop.Word.Field field in document.Fields)
                {
                    if (field.Code.Text.Contains("Roll no"))
                    {
                        field.Select();
                        application.Selection.TypeText(roll_no);
                    }
                    else if (field.Code.Text.Contains("First name"))
                    {
                        field.Select();
                        application.Selection.TypeText(F_name);
                    }
                    else if (field.Code.Text.Contains("Last name"))
                    {
                        field.Select();
                        application.Selection.TypeText(L_name);



                    }
                    else if (field.Code.Text.Contains("n_science"))
                    {
                        field.Select();
                        application.Selection.TypeText(m_science);
                    }
                    else if (field.Code.Text.Contains("n_maths"))
                    {
                        field.Select();
                        application.Selection.TypeText(m_maths);
                    }
                    else if (field.Code.Text.Contains("n_gk"))
                    {
                        field.Select();
                        application.Selection.TypeText(m_gk);
                    }
                    else if (field.Code.Text.Contains("n_nepali"))
                    {
                        field.Select();
                        application.Selection.TypeText(m_nepali);
                    }
                    else if (field.Code.Text.Contains("n_english"))
                    {
                        field.Select();
                        application.Selection.TypeText(m_english);
                    }
                    else if (field.Code.Text.Contains("n_drawing"))
                    {
                        field.Select();
                        application.Selection.TypeText(m_drawing);
                    }

                    else if (field.Code.Text.Contains("n_social"))
                    {
                        field.Select();
                        application.Selection.TypeText(m_social);
                    }




                    else if (field.Code.Text.Contains("g_maths"))
                    {
                        field.Select();
                        application.Selection.TypeText(g_maths);
                    }
                    else if (field.Code.Text.Contains("g_science"))
                    {
                        field.Select();
                        application.Selection.TypeText(g_science);
                    }
                    else if (field.Code.Text.Contains("g_nepali"))
                    {
                        field.Select();
                        application.Selection.TypeText(g_nepali);
                    }

                    else if (field.Code.Text.Contains("g_english"))
                    {
                        field.Select();
                        application.Selection.TypeText(g_english);
                    }
                    else if (field.Code.Text.Contains("g_gk"))
                    {
                        field.Select();
                        application.Selection.TypeText(g_gk);
                    }
                    else if (field.Code.Text.Contains("g_social"))
                    {
                        field.Select();
                        application.Selection.TypeText(g_social);
                    }
                    else if (field.Code.Text.Contains("g_drawing"))
                    {
                        field.Select();
                        application.Selection.TypeText(g_drawing);
                    }



                    else if (field.Code.Text.Contains("gpa_gk"))
                    {
                        field.Select();
                        application.Selection.TypeText(gpa_gk);
                    }
                    else if (field.Code.Text.Contains("gpa_maths"))
                    {
                        field.Select();
                        application.Selection.TypeText(gpa_maths);
                    }
                    else if (field.Code.Text.Contains("gpa_science"))
                    {
                        field.Select();
                        application.Selection.TypeText(gpa_science);
                    }
                    else if (field.Code.Text.Contains("gpa_social"))
                    {
                        field.Select();
                        application.Selection.TypeText(gpa_social);
                    }
                    else if (field.Code.Text.Contains("gpa_english"))
                    {
                        field.Select();
                        application.Selection.TypeText(gpa_english);
                    }
                    else if (field.Code.Text.Contains("gpa_nepali"))
                    {
                        field.Select();
                        application.Selection.TypeText(gpa_nepali);
                    }
                    else if (field.Code.Text.Contains("gpa_drawing"))
                    {
                        field.Select();
                        application.Selection.TypeText(gpa_drawing);
                    }

                    else if (field.Code.Text.Contains("total_gpa"))
                    {
                        field.Select();
                        application.Selection.TypeText(t_gpa);
                    }
                    else if (field.Code.Text.Contains("Attendance"))
                    {
                        field.Select();
                        application.Selection.TypeText(attend);
                    }



                }

                document.SaveAs(FileName: @"C:\Users\Aayush\Desktop\c# project\Project_v2\Result\Class-1\Result of " + F_name + ".docx");





            }
            MessageBox.Show("Results Created");
        }











    }
}
