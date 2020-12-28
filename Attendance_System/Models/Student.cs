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
    public class Student
    {
        public int studID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string coursename { get; set; }
        public int fees { get; set; }
        public DateTime admitdate { get; set; }
        public string coursetype { get; set; }
        public bool active { get; set; }
        public int courseID { get; set; }
        public int No_of_M_H { get; set; }
        public DateTime courseenddate { get; set; }

        public static SqlCommand com;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;


        
        public Student()
        {
            Myconnection k = new Myconnection();
            con = k.Getconnection();
            com = new SqlCommand();

        }


        public DataSet Getstudents()
        {
            
            com.CommandText = "select studID,fname+ ' ' +lname as name from Students where active=@active";
            SqlParameter p1 = new SqlParameter("@active", SqlDbType.Bit);
            p1.Value = true;
            com.Parameters.Add(p1);
            com.CommandType = CommandType.Text;
            com.Connection=con;
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            return ds;
            
        }

        public DataSet GetHourlystudents()
        {

            com.CommandText = "select studID,fname+ ' ' +lname as name from Students where active=@active and coursetype=@coursetype ";
            SqlParameter p1 = new SqlParameter("@active", SqlDbType.Bit);
            SqlParameter p2 = new SqlParameter("@coursetype", SqlDbType.VarChar);


            p1.Value = true;
            p2.Value = "Hour/s";

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
         
            com.CommandType = CommandType.Text;
            com.Connection = con;
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            return ds;

        }



        public int Addstudent()
        {
            com.Parameters.Clear();
           
            com.Connection = con;
            com.CommandText = "insert into Students (fname,lname,coursetype,coursename,admitdate,active,fees,No_of_M_H)values(@fname,@lname,@coursetype,@coursename,@admitdate,@active,@fees,@No_of_M_H)";
           
            SqlParameter p1 = new SqlParameter("@fname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@lname", SqlDbType.VarChar);
            SqlParameter p3 = new SqlParameter("@coursetype",SqlDbType.VarChar);
            SqlParameter p4 = new SqlParameter("@coursename", SqlDbType.VarChar);
            SqlParameter p5 = new SqlParameter("@admitdate", SqlDbType.DateTime);
            SqlParameter p6 = new SqlParameter("@active", SqlDbType.Bit);
            SqlParameter p7 = new SqlParameter("@fees", SqlDbType.Int);
            SqlParameter p8 = new SqlParameter("@No_of_M_H", SqlDbType.Int);

            p1.Value = fname;
            p2.Value = lname;
            p3.Value = coursetype;
            p4.Value = coursename;
            p5.Value = admitdate;
            p6.Value = active;
            p7.Value = fees;
            p8.Value = No_of_M_H;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);
            com.Parameters.Add(p5);
            com.Parameters.Add(p6);
            com.Parameters.Add(p7);
            com.Parameters.Add(p8);

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int Changestudent()
        {
            com.Parameters.Clear();
            
            com.Connection = con;
            com.CommandText = "update Students set fname=@fname,lname=@lname,coursetype=@coursetype,coursename=@coursename,admitdate=@admitdate,fees=@fees,courseID=@courseID,No_of_M_H=@No_of_M_H where studID=@studID";

            SqlParameter p1 = new SqlParameter("fname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@lname", SqlDbType.VarChar);
            SqlParameter p3 = new SqlParameter("@coursetype", SqlDbType.VarChar);
            SqlParameter p4 = new SqlParameter("@coursename", SqlDbType.VarChar);
            SqlParameter p5 = new SqlParameter("@admitdate", SqlDbType.DateTime);
            SqlParameter p6 = new SqlParameter("@fees", SqlDbType.Int);
            SqlParameter p7 = new SqlParameter("@courseID", SqlDbType.Int);
            SqlParameter p8 = new SqlParameter("@studID", SqlDbType.Int);
            SqlParameter p9 = new SqlParameter("@No_of_M_H", SqlDbType.Int);

            p1.Value = fname;
            p2.Value = lname;
            p3.Value = coursetype;
            p4.Value = coursename;
            p5.Value = admitdate;
            p6.Value = fees;
            p7.Value = courseID;
            p8.Value = studID;
            p9.Value = No_of_M_H;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);
            com.Parameters.Add(p5);
            com.Parameters.Add(p6);
            com.Parameters.Add(p7);
            com.Parameters.Add(p8);
            com.Parameters.Add(p9);

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public void Getstudent(int ID)
        {
            com.Parameters.Clear();
            
            com.Connection = con;
            com.CommandText = "Select fname,lname,coursetype,coursename,fees,admitdate,No_of_M_H from students where studID=@studID and active=@active";
            SqlParameter p1 = new SqlParameter("@studID", SqlDbType.Int);
            SqlParameter p2 = new SqlParameter("@active", SqlDbType.Bit);
            p1.Value = ID;
            p2.Value = true;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);

            con.Open();
            dr = com.ExecuteReader();
            while(dr.Read())
            {
                fname = dr[0].ToString();
                lname = dr[1].ToString();

                coursetype = dr[2].ToString();
                coursename = dr[3].ToString();
                fees = Convert.ToInt32(dr[4].ToString());
                admitdate = Convert.ToDateTime(dr[5].ToString());
                No_of_M_H = Convert.ToInt32(dr[6].ToString());

            }
           
            con.Close();
            dr.Close();




        }
        public void SearchStudent(int id)
        {
            com.Parameters.Clear();

            com.Connection = con;
            com.CommandText = "Select fname,lname  from students where studID=@studID and active=@active";
            SqlParameter p1 = new SqlParameter("@studID", SqlDbType.Int);
            SqlParameter p2 = new SqlParameter("@active", SqlDbType.Bit);
            p1.Value = id;
            p2.Value = true;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);

            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                fname = dr[0].ToString();
                lname = dr[1].ToString();
                 

            }

            con.Close();
            dr.Close();


        }
        public int updatestudent()
        {
            
            
            com.Parameters.Clear();
            com.Connection = con;
            com.CommandText = "update students set courseenddate=@courseenddate, active=@active where studID=@studID";

            SqlParameter p1 = new SqlParameter("@studID", SqlDbType.Int);
            SqlParameter p2 = new SqlParameter("@courseenddate", SqlDbType.DateTime);
            SqlParameter p3 = new SqlParameter("@active", SqlDbType.Bit);

            p1.Value = studID;
            p2.Value = courseenddate;
            p3.Value = active;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int Gettotalhours(int ID)
        {
            com.Connection = con;
            com.CommandText = "select No_of_M_H from Students where studID=@studID";
            SqlParameter p1 = new SqlParameter("@studID", SqlDbType.Int);

            p1.Value = ID;

            com.Parameters.Add(p1);
            con.Open();
            int n =Convert.ToInt32( com.ExecuteScalar());
            return n;

        }
        public int Getfees(int ID)
        {
            com.Connection = con;
            com.CommandText = "select fees from Students where studID=@studID";
            SqlParameter p1 = new SqlParameter("@studID", SqlDbType.Int);

            p1.Value = ID;

            com.Parameters.Add(p1);
            con.Open();
            int n = Convert.ToInt32(com.ExecuteScalar());
            return n;
        }


    }
}