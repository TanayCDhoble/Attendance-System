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
    public partial class AttendanceForm : System.Web.UI.Page
    {
        public static SqlCommand com;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        Attendanceclass a;
        string presenty;
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!Page.IsPostBack)
            { 
                    Student b = new Student();
                    ds = new DataSet();//return data set 
                ds = b.Getstudents();
                    DropDownList1.DataSource = ds.Tables[0];
                    DropDownList1.DataTextField = "name";
                    DropDownList1.DataValueField = "studID";
                    DropDownList1.DataBind();
            }

        }

        protected void btnsubmitattendace_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate.ToString() == String.Empty)
            {
                MessageBox.Show("Date should be selected");
            }
            else
            {
                try
                {
                    Attendanceclass a = new Attendanceclass();
                    a.studID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
                    a.presenty = DropDownList2.SelectedItem.ToString();
                    a.attdate = Calendar1.SelectedDate;
                    int r = a.addattendance();
                    if (r > 0)
                    {
                        MessageBox.Show("Attendance Added");
                    }
                    else
                    {
                        MessageBox.Show("There is a problem");
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = new Attendanceclass();
            int ID= Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            Student s = new Student();
            int n = s.Gettotalhours(ID);
            //a.balancehours = a.Getbalancehours(ID);
            //MessageBox.Show(n.ToString());
            //MessageBox.Show(a.balancehours.ToString());

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenty = DropDownList2.SelectedItem.ToString();
            //MessageBox.Show(presenty);
        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            
        }

        protected void btndetail_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            Attendanceclass a = new Attendanceclass();
            a.studID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
            int id = a.studID;

          
            int n = a.Gethours(id);
            int total = s.Gettotalhours(id);
            Labeldetail.Text = "Total hours/Months " + total.ToString() + "  Present hours  " + n.ToString();

        }
    }
}