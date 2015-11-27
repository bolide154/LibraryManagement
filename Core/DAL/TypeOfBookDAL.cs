using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class TypeOfBookDAL
    {
        public static Connection _condb = new Connection();
        public static List<TypeOfBookBLL> getTypeOfBookList()
        {
            String sql = "SELECT * FROM [theloai]";
            DataTable dt = new DataTable();
            dt = TypeOfBookDAL._condb.getDataTable(sql);
            List<TypeOfBookBLL> typeOfBookBLLList = new List<TypeOfBookBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL(Int32.Parse(row["matheloai"].ToString()), row["tentheloai"].ToString());
                    typeOfBookBLLList.Add(typeOfBookBLL);
                }
                return typeOfBookBLLList;
            }
            else
            {
                return null;
            }
        }
        public static List<TypeOfBookBLL> search(string catalog, string keyword)
        {
            String sql = "SELECT * FROM [theloai] WHERE " + catalog + " LIKE '%" + keyword + "%'";
            DataTable dt = new DataTable();
            dt = TypeOfBookDAL._condb.getDataTable(sql);
            List<TypeOfBookBLL> typeOfBookBLLList = new List<TypeOfBookBLL>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL(Int32.Parse(row["matheloai"].ToString()), row["tentheloai"].ToString());
                    typeOfBookBLLList.Add(typeOfBookBLL);
                }
                return typeOfBookBLLList;
            }
            else
            {
                return null;
            }
        }

        public static void addTypeOfBook(TypeOfBookBLL typeOfBookBLL)
        {
            String sql = "INSERT INTO [theloai] (tentheloai) VALUES ( N'" + typeOfBookBLL.Name + "')";
            TypeOfBookDAL._condb.ExecuteNonQuery(sql);
        }

        public static void deleteTypeOfBook(TypeOfBookBLL typeOfBookBLL)
        {
            String sql = "DELETE FROM [theloai] WHERE matheloai=" + typeOfBookBLL.TypeOfBookId;
            TypeOfBookDAL._condb.ExecuteNonQuery(sql);
        }
        public static void updateTypeOfBook(TypeOfBookBLL typeOfBookBLL)
        {
            String sql = "UPDATE [theloai] SET tentheloai=N'" + typeOfBookBLL.Name + "' WHERE matheloai=" + typeOfBookBLL.TypeOfBookId;
            TypeOfBookDAL._condb.ExecuteNonQuery(sql);
        }

        public static TypeOfBookBLL getTypeOfBookItem(TypeOfBookBLL typeOfBookBLL)
        {
            String sql = "SELECT * FROM [theloai] WHERE matheloai=" + typeOfBookBLL.TypeOfBookId;
            DataTable dt = TypeOfBookDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new TypeOfBookBLL(Int32.Parse(row["matheloai"].ToString()), row["tentheloai"].ToString());
            }
            else
            {
                return null;
            }
        }
    }
}
