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
    public partial class StudentForm : System.Web.UI.Page
    {
        public static SqlCommand com;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        string f, coursetype, coursename;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CourseClass c = new CourseClass();
                ds = new DataSet();
                ds = c.GetCourses();
                DropDownList1.DataSource = ds.Tables[0];
                DropDownList1.DataTextField = "coursename";
                DropDownList1.DataValueField = "fees";
                DropDownList1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == String.Empty )
            {
                MessageBox.Show("First Name OR Last Name cannot be empty");
            }
           else if(txtfees.Text==String.Empty)

            {
                MessageBox.Show("Fees should be entered");
            }
            else if(txtdate.Text==String.Empty)
            {
                MessageBox.Show("Date should be entered");
            }
            else if (txtMH.Text == String.Empty)
            {
                MessageBox.Show("Months/Hours should be entered");
            }
            else
            {
                try
                {

                    Student s = new Student();
                    s.fname = txtfname.Text;
                    s.lname = txtlname.Text;
                    s.fees = Convert.ToInt32(txtfees.Text);

                    s.No_of_M_H = Convert.ToInt32(txtMH.Text);
                    s.coursetype = DropDownList2.SelectedItem.ToString();
                    s.coursename = DropDownList1.SelectedItem.ToString();
                    s.admitdate = Convert.ToDateTime(txtdate.Text);
                    s.active = true;
                    int r = s.Addstudent();
                    if (r > 0)
                    {
                        MessageBox.Show("Record Added Succesfully");
                    }


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtMH.Text = String.Empty;
            txtlname.Text = String.Empty;
            txtfname.Text = String.Empty;
            txtfees.Text = String.Empty;
            txtdate.Text = String.Empty;
            labelfees.Text = String.Empty;
            txtID.Text = String.Empty;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Student s = new Student();
                s.studID = Convert.ToInt32(txtID.Text);
                s.fname = txtfname.Text;
                s.lname = txtlname.Text;
                s.coursename = DropDownList1.SelectedItem.ToString();
                s.fees = Convert.ToInt32(txtfees.Text);
                s.No_of_M_H = Convert.ToInt32(txtMH.Text);
                s.coursetype = DropDownList2.SelectedItem.ToString();
                s.admitdate = Convert.ToDateTime(txtdate.Text);
                int r = s.Changestudent();
                MessageBox.Show(r + " Record Updated Succesfully");

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        protected void Btnsearchh_Click(object sender, EventArgs e)
        {
            try
            {

                Student s = new Student();
                int ID = Convert.ToInt32(txtID.Text);
                s.Getstudent(ID);

                txtfname.Text = s.fname;
                txtlname.Text = s.lname;
                txtfees.Text = s.fees.ToString();

                txtMH.Text = s.No_of_M_H.ToString();

                txtdate.Text = s.admitdate.ToShortDateString();

                //DropDownList1.SelectedItem.Text = DropDownList1.ToString();
                //DropDownList2.SelectedItem.Text = DropDownList2.SelectedItem.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            coursetype = DropDownList2.SelectedItem.ToString();
            //MessageBox.Show(coursetype); 
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = DropDownList1.SelectedValue.ToString();
            labelfees.Text = f;
            coursename = DropDownList1.SelectedItem.ToString();

            //MessageBox.Show(DropDownList1.SelectedItem.ToString());
        }
    }
}