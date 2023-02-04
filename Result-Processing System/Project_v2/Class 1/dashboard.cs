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
    public partial class dashboard : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\Users\Aayush\Desktop\c# project\Project_v2\Result-Processing System\Database\Database.mdb'");
        OleDbCommand cmd = new OleDbCommand();
        public dashboard()
        {
            InitializeComponent();
            string sql = "Select * from Std_Data";
            OleDbCommand cmmd = new OleDbCommand(sql, conn);
            DataSet ds = new DataSet();
            OleDbDataAdapter daa = new OleDbDataAdapter(cmmd);
            daa.Fill(ds);
            lbl_student_count.Text = ds.Tables[0].Rows.Count.ToString();


            string query= "Select * from Class_1";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            DataSet dss = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dss);
            lbl_result_count.Text = dss.Tables[0].Rows.Count.ToString();
        }
    }
}
