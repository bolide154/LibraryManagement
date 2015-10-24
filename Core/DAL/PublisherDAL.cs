using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    class PublisherDAL
    {
        public DataTable LoadPublisherList()
        {
            SqlConnection conn = Connection.ConnectionData();
            String sql = "SELECT * FROM [nhaxuatban]";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
