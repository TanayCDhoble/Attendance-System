using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Attendance;

namespace Attendance_System
{
    public partial class Search : System.Web.UI.Page
    {
        public string fname { get; set; }
        public string lname { get; set; }

        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataAdapter da;
        public static SqlDataReader dr;
        public static DataTable dt;
        public static DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                Myconnection c = new Attendance.Myconnection();
                c.Getconnection();
                com = new SqlCommand();
                com.Connection = con;
                string fname = txtsearch.Text;
                com.CommandText = "Select * from Studentattendance_view where fname=@fname";
                SqlParameter p1 = new SqlParameter("@fname", SqlDbType.VarChar);
                p1.Value = fname;

                com.Parameters.Add(p1);

                da = new SqlDataAdapter(com);
                ds = new DataSet();
                da.SelectCommand = com;
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}