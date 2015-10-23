using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    class Connection
    {
        public static SqlConnection ConnectionData()
        {
            string server = "VIEN\\SQLEXPRESS";
            string database = "library_management_db";
            string connStr = "Server=" + server + "; Database=" + database + "; Trusted_Connection=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            return conn;
        }
    }
}
