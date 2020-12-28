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
    public partial class CourseForm : System.Web.UI.Page
    {
        public static SqlCommand com;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        string f;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnaddcourse_Click(object sender, EventArgs e)
        {
            if (txtcoursename.Text == String.Empty)
            {
                MessageBox.Show("CourseName Should be Added");
            }
            else if(txtcoursefees.Text==String.Empty)
            {
                MessageBox.Show("Fees Shouldbe Added");
            }
            else
            {
                try
                {

                    CourseClass p = new CourseClass();
                    //txtcoursefees.Text = f;
                    //p.No_of_M_H = Convert.ToInt32(txtMH.Text);
                    //p.coursetype = DropDownList1.SelectedItem.ToString();
                    p.fees = Convert.ToInt32(txtcoursefees.Text);
                    p.coursename = txtcoursename.Text;
                    int r = p.Addcourse();
                    MessageBox.Show(r + "Course Added Succesfully");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            txtcourseid.Text = String.Empty;
            txtcoursename.Text = String.Empty;
            txtcoursefees.Text = String.Empty;
           
        }

        protected void btnsearchcourseid_Click(object sender, EventArgs e)
        {
            if (txtcourseid.Text == String.Empty)
            {
                MessageBox.Show("ID should be enter for search");
            }
            else {
                try
                {
                    CourseClass p = new CourseClass();
                    int ID = Convert.ToInt32(txtcourseid.Text);
                    p.Getcourse(ID);
                    txtcoursename.Text = p.coursename;
                    txtcoursefees.Text = p.fees.ToString();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        protected void btnchangecourse_Click(object sender, EventArgs e)
        {
            if (txtcoursename.Text == String.Empty)
            {
                MessageBox.Show("CourseName Should be Added");
            }
            else if (txtcoursefees.Text == String.Empty)
            {
                MessageBox.Show("Fees Shouldbe Added");
            }
            else
            {


                try
                {
                    CourseClass p = new CourseClass();
                    p.courseID = Convert.ToInt32(txtcourseid.Text);
                    p.coursename = txtcoursename.Text;

                    p.fees = Convert.ToInt32(txtcoursefees.Text);

                    int r = p.Changecourse();
                    MessageBox.Show(r + "Changes made succesfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}