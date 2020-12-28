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
    public partial class PaymentForm : System.Web.UI.Page
    {
        public static SqlCommand com;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        int g;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                 Student s= new Student();
                ds = new DataSet();
                ds = s.Getstudents();
                DropDownname.DataSource = ds.Tables[0];
                DropDownname.DataTextField = "name";
                DropDownname.DataValueField = "studID";
                DropDownname.DataBind();

            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Payment p = new Payment();
                p.studID = Convert.ToInt32(DropDownname.SelectedValue.ToString());
                p.paydate = Convert.ToDateTime(txtdate.Text);
                p.balance = Convert.ToInt32(txtbalance.Text);
                p.payment = Convert.ToInt32(txtpayment.Text);
                int r = p.addpayment();
                if (r > 0)
                {
                    MessageBox.Show("Payment Added Succesfully");

                }
                else
                {
                    MessageBox.Show("There is an error");
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        protected void btnclear_Click(object sender, EventArgs e)
        {
            txtbalance.Text = String.Empty;
            txtdate.Text = String.Empty;
            txtpayment.Text = String.Empty;
        }

        protected void txtpayment_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void DropDownname_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student s = new Student();
            s.studID = Convert.ToInt32(DropDownname.SelectedValue.ToString());
            g = s.Getfees(s.studID);
            Labelfees.Text = g.ToString();
         

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtbalance.Text = (int.Parse(Labelfees.Text) - int.Parse(txtpayment.Text)).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}