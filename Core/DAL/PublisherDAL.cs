using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class PublisherDAL
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

        public bool AddPublisher(PublisherBLL publisherBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "INSERT INTO [nhaxuatban] (tennxb, sdtnxb, diachinxb)"
                    + " VALUES ( N'" + publisherBLL.Name + "', N'" + publisherBLL.Phone + "', N'"+publisherBLL.Address+"')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeletePublisher(int id)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "DELETE FROM [nhaxuatban] WHERE manxb=" + id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdatePublisher(PublisherBLL publisherBLL)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "UPDATE [nhaxuatban] SET tennxb=N'" + publisherBLL.Name + "', sdtnxb=N'" + publisherBLL.Phone + "', diachinxb=N'" + publisherBLL.Address + "' WHERE manxb=" + publisherBLL.PublisherId;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable Search(string catalog, string key)
        {
            string sql = "";
            if (key != "")
            {
                if (catalog == "" || catalog == "Serch by...")
                {
                    sql = "SELECT * FROM [nhaxuatban] WHERE tennxb LIKE '%" + key + "%'";
                }
                else if (catalog == "Name")
                {
                    sql = "SELECT * FROM [nhaxuatban] WHERE tennxb LIKE '%" + key + "%'";
                }
                else if (catalog == "Phone Number")
                {
                    sql = "SELECT * FROM [nhaxuatban] WHERE sdtnxb LIKE '%" + key + "%'";
                }
                else if (catalog == "Address")
                {
                    sql = "SELECT * FROM [nhaxuatban] WHERE diachinxb LIKE '%" + key + "%'";
                }
            }
            SqlConnection conn = Connection.ConnectionData();
            System.Console.Write(sql);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DataTable CheckDelete(int id)
        {
            try
            {
                SqlConnection conn = Connection.ConnectionData();
                String sql = "SELECT * FROM [dausach] WHERE manxb=" + id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
