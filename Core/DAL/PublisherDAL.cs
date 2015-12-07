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
    public static class PublisherDAL
    {
        public static Connection _condb = new Connection();
        public static List<PublisherBLL> getPublisherList()
        {
            String sql = "SELECT * FROM [nhaxuatban]";
            DataTable dt = PublisherDAL._condb.getDataTable(sql);
            List<PublisherBLL> publisherBLLList = new List<PublisherBLL>();
            if (dt.Rows.Count > 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    PublisherBLL publisherBLL = new PublisherBLL(Int32.Parse(row["manxb"].ToString()), row["tennxb"].ToString(), row["sdtnxb"].ToString(), row["diachinxb"].ToString());
                    publisherBLLList.Add(publisherBLL);
                }
                return publisherBLLList;
            }
            else
            {
                return null;
            }
        }

        public static void addPublisher(PublisherBLL publisherBLL)
        {
                String sql = "INSERT INTO [nhaxuatban] (tennxb, sdtnxb, diachinxb)"
                    + " VALUES ( N'" + publisherBLL.Name + "', N'" + publisherBLL.Phone + "', N'"+publisherBLL.Address+"')";
                PublisherDAL._condb.ExecuteNonQuery(sql);
        }
        public static void deletePublisher(PublisherBLL publisherBLL)
        {
                String sql = "DELETE FROM [nhaxuatban] WHERE manxb=" + publisherBLL.PublisherId;
                PublisherDAL._condb.ExecuteNonQuery(sql);
        }
        public static void updatePublisher(PublisherBLL publisherBLL)
        {
                String sql = "UPDATE [nhaxuatban] SET tennxb=N'" + publisherBLL.Name + "', sdtnxb=N'" + publisherBLL.Phone + "', diachinxb=N'" + publisherBLL.Address + "' WHERE manxb=" + publisherBLL.PublisherId;
                PublisherDAL._condb.ExecuteNonQuery(sql);
        }

        public static List<PublisherBLL> search(string catalog, string key)
        {
            string sql = "SELECT * FROM [nhaxuatban] WHERE "+catalog+" LIKE '%" + key + "%'";
            DataTable dt = PublisherDAL._condb.getDataTable(sql);
            List<PublisherBLL> publisherBLLList = new List<PublisherBLL>();
            if (dt.Rows.Count > 1)
            {
                foreach (DataRow row in dt.Rows)
                {
                    PublisherBLL publisherBLL = new PublisherBLL(Int32.Parse(row["manxb"].ToString()), row["tennxb"].ToString(), row["sdtnxb"].ToString(), row["diachinxb"].ToString());
                    publisherBLLList.Add(publisherBLL);
                }
                return publisherBLLList;
            }
            else
            {
                return null;
            }
        }

        public static PublisherBLL getPublisherItem(PublisherBLL publiserBLL)
        {
            String sql = "SELECT * FROM [nhaxuatban] WHERE manxb=" + publiserBLL.PublisherId;
            DataTable dt = PublisherDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new PublisherBLL(Int32.Parse(row["manxb"].ToString()), row["tennxb"].ToString(), row["sdtnxb"].ToString(), row["diachinxb"].ToString());
            }
            else
            {
                return null;
            }
        }
        public static List<PublisherBLL> getPublisherItem(string publisherName)
        {
            String sql = "SELECT * FROM [nhaxuatban] WHERE tennxb LIKE N'%" + publisherName + "%'";
            DataTable dt = PublisherDAL._condb.getDataTable(sql);
            List<PublisherBLL> publisherList = new List<PublisherBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    publisherList.Add(new PublisherBLL(Int32.Parse(row["manxb"].ToString()), row["tennxb"].ToString(), row["sdtnxb"].ToString(), row["diachinxb"].ToString()));
                }
                return publisherList;
            }
            else
            {
                return null;
            }
        }
    }
}
