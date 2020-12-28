using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Attendance
{
    public partial class Edit : System.Web.UI.Page
    {
        public static SqlCommand com;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnsearch_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == String.Empty)
            {
                MessageBox.Show("ID should be enter for search");
            }
            else
            {
                try
                {
                    Student w = new Student();
                    int id = Convert.ToInt32(TextBox1.Text);
                    w.SearchStudent(id);
                    Labeltext.Text = w.fname;
                    labeltext2.Text = w.lname;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        protected void Btnendbatch_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == String.Empty)
            {
                MessageBox.Show("Date should be entered");
            }
            else
            {
                try
                {
                    Student w = new Student();
                    w.studID = Convert.ToInt32(TextBox1.Text);

                    w.courseenddate = Convert.ToDateTime(TextBox2.Text);
                    w.active = false;
                    int r = w.updatestudent();
                    MessageBox.Show(r + "Record Deleted");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}