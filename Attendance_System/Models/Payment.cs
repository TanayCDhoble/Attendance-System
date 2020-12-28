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
    public class Payment
    {
        public int payID { get; set; }
        public int studID { get; set; }
        public int payment { get; set; }
        public int balance { get; set; }
        public DateTime paydate { get; set; }
        public string fname { get; set; }

        public static SqlCommand com;
        public static SqlConnection con;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        public Payment()
        {
            Myconnection k = new Myconnection();
            con = k.Getconnection();
            com = new SqlCommand();

        }

        public  DataSet Getpayment()
        {
            com.CommandText = "select * from Transactions";
            com.CommandType = CommandType.Text;
            com.Connection = con;
            da = new SqlDataAdapter(com);
            ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public int addpayment()
        {
            com.Parameters.Clear();
            com.Connection = con;
            com.CommandText = "insert into Transactions(studID,payment,balance,paydate)values (@studID,@payment,@balance,@paydate)";
            
            SqlParameter p1 = new SqlParameter("@payment", SqlDbType.Int);
            SqlParameter p2 = new SqlParameter("@balance", SqlDbType.Int);
            SqlParameter p3 = new SqlParameter("@paydate", SqlDbType.DateTime);
            SqlParameter p4 = new SqlParameter("@studID", SqlDbType.Int);

            p1.Value = payment;
            p2.Value = balance;
            p3.Value = paydate;
            p4.Value = studID;


            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;

        }

        public int Changepayment()
        {
            com.Parameters.Clear();
            com.Connection = con;
            com.CommandText = "update Transactions set fname=@fname,payment=@payment,balance=@balance,paydate=@paydate where payID=@payID";

            SqlParameter p1 = new SqlParameter("@fname", SqlDbType.VarChar);
            SqlParameter p2 = new SqlParameter("@payment", SqlDbType.Int);
            SqlParameter p3 = new SqlParameter("@balance", SqlDbType.Int);
            SqlParameter p4 = new SqlParameter("@paydate", SqlDbType.DateTime);
            SqlParameter p5 = new SqlParameter("@payID", SqlDbType.Int);

            p1.Value = fname;
            p2.Value = payment;
            p3.Value = balance;
            p4.Value = paydate;
            p4.Value = payID;

            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            com.Parameters.Add(p4);
            com.Parameters.Add(p5);

            con.Open();
            int rows = com.ExecuteNonQuery();
            con.Close();
            return rows;

        }

       
    }
}