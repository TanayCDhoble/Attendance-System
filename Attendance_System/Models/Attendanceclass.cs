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
    public class Attendanceclass
    {
        public string fname { get; set; }
        public int attID { get; set; }
        public int studID { get; set; }
        public int totalhours { get; set; }
        public string presenty { get; set; }
        public int balancehours { get; set; }
        public DateTime attdate { get; set; }

        public static SqlCommand com;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        int n;
        public Attendanceclass()
            {
                Myconnection k = new Myconnection();
                con = k.Getconnection();
                com = new SqlCommand();

            }
        

        public DataSet Getattendace()
        {
            com.CommandText = "select * from Attendance";
            com.CommandType = CommandType.Text;
            com.Connection = con;
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public int addattendance()
        {
            com.Parameters.Clear();
            com.Connection = con;
            com.CommandText = "insert into Attendance(studID,presenty,attdate)values(@studID,@presenty,@attdate)";

            SqlParameter p1 = new SqlParameter("@studID", SqlDbType.VarChar);
            
            SqlParameter p2 = new SqlParameter("@presenty", SqlDbType.VarChar);
            
            SqlParameter p3 = new SqlParameter("@attdate", SqlDbType.DateTime);

            p1.Value = studID;
            
            p2.Value = presenty;
          
            p3.Value = attdate;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;
        

        }
        public int Changeattendance()
        {
            com.Parameters.Clear();
            com.Connection = con;
            com.CommandText = "update Transaction set fname=@fname,totalhours=@totalhours,presenty=@presenty,balancehours=@balancehours,attdate=@attdate where attID=@attID";
            SqlParameter p1 = new SqlParameter("@fname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@totalhours", SqlDbType.Int);
            SqlParameter p3 = new SqlParameter("@presenty", SqlDbType.VarChar);
            SqlParameter p4 = new SqlParameter("@balancehours", SqlDbType.Int);
            SqlParameter p5 = new SqlParameter("@attdate", SqlDbType.DateTime);
            SqlParameter p6 = new SqlParameter("@attID", SqlDbType.Int);

            p1.Value = fname;
            p2.Value = totalhours;
            p3.Value = presenty;
            p4.Value = balancehours;
            p5.Value = attdate;
            p6.Value = attID;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);
            com.Parameters.Add(p5);
            com.Parameters.Add(p6);

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;

        }
        public int Gethours(int id)
        {
            try
            {
                Student s = new Student();

                com.Connection = con;
                com.CommandText = "select count(presenty) as PresentDays from  Attendance where studID = @studID and presenty='Present'";
                SqlParameter p1 = new SqlParameter("@studID", SqlDbType.Int);

                p1.Value = id;

                com.Parameters.Add(p1);
                con.Open();
                n = Convert.ToInt32(com.ExecuteScalar());

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            return n;


        }

    }
}