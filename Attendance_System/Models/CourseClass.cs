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




namespace Attendance
{
    public class CourseClass
    {

        public int courseID { get; set; }
        public string coursename { get; set; }
        public string coursetype { get; set; }
        public int fees { get; set; }
        public bool active { get; set; }
        public int No_of_M_H { get; set; }

        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public CourseClass()
        {
            Myconnection k = new Myconnection();
            con = k.Getconnection();

        }

        public DataSet GetCourses()
        {
            com = new SqlCommand();
            com.CommandText = "Select courseId,coursename,fees from Course";
            com.CommandType = CommandType.Text;
            com.Connection = con;
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public int Addcourse()
        {

            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Insert into Course (coursename,fees)values(@coursename,@fees)";

            SqlParameter p1 = new SqlParameter("@coursename", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@fees", SqlDbType.Int);


            p1.Value = coursename;
            p2.Value = fees;


            com.Parameters.Add(p1);
            com.Parameters.Add(p2);


            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;
        }

        public int Changecourse()
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "update Course set coursename=@coursename,fees=@fees where courseID=@CourseID";

            SqlParameter p1 = new SqlParameter("@coursename", SqlDbType.VarChar);

            SqlParameter p2 = new SqlParameter("@fees", SqlDbType.Int);
            SqlParameter p3 = new SqlParameter("@courseID", SqlDbType.Int);



            p1.Value = coursename;

            p2.Value = fees;
            p3.Value = courseID;


            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);


            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;
        }

        public void Getcourse(int ID)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select  coursename,fees from Course where courseID=@courseID";
            SqlParameter p1 = new SqlParameter("@courseID", SqlDbType.Int);

            p1.Value = ID;

            com.Parameters.Add(p1);

            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                coursename = dr[0].ToString();
                fees = Convert.ToInt32(dr[1].ToString());

            }
            con.Close();
            dr.Close();

        }
        public int updatecourse()

        {

            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "update course set active=@active where courseID=@courseID";

            SqlParameter p1 = new SqlParameter("@courseID", SqlDbType.Int);
            p1.Value = courseID;
            com.Parameters.Add(p1);

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;



        }


    }
}