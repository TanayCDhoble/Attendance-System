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
using System.Configuration;
using System.Web.Configuration;


namespace Attendance
{
    public class Myconnection
    {
        public static SqlConnection con;
        public SqlConnection Getconnection()
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ProjectDBconnect"].ToString());
            return con;
        }
    }
}