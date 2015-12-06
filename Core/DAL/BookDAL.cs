﻿using Core.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public static class BookDAL
    {
        public static Connection _condb = new Connection();
        public static List<BookBLL> getBookList(int bookTitleId)
        {
            string sql = "SELECT * FROM [sach] WHERE madausach="+bookTitleId;
            DataTable dt = BookDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<BookBLL> bookList = new List<BookBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    BookBLL bookBLL = new BookBLL(Int32.Parse(row["masach"].ToString()), Int32.Parse(row["madausach"].ToString()), Int32.Parse(row["matinhtrangsach"].ToString()));
                    bookList.Add(bookBLL);
                }
                return bookList;
            }
            return null;
        }
        public static List<BookBLL> getBookList()
        {
            string sql = "SELECT * FROM [sach]";
            DataTable dt = BookDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<BookBLL> bookList = new List<BookBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    BookBLL bookBLL = new BookBLL(Int32.Parse(row["masach"].ToString()), Int32.Parse(row["madausach"].ToString()), Int32.Parse(row["matinhtrangsach"].ToString()));
                    bookList.Add(bookBLL);
                }
                return bookList;
            }
            return null;
        }
        public static void addBook(BookBLL bookBLL)
        {
            String sql = "INSERT INTO [sach] (madausach, matinhtrangsach) VALUES ( " + bookBLL.BookTitleId + ", " + bookBLL.BookStatusId + ")";
            BookDAL._condb.ExecuteNonQuery(sql);
        }

        public static void updateBookStatus(BookTitleBLL bookTitleBLL, int bookStatusId)
        {
            String sql = "UPDATE [sach] SET matinhtrangsach=" + bookStatusId + "  WHERE madausach=" + bookTitleBLL.BookTitleId;
            BookTitleDAL._condb.ExecuteNonQuery(sql);
        }

        public static List<BookBLL> getBookList(BookTitleBLL bookTitleBLL)
        {
            string sql = "SELECT * FROM [sach] WHERE madausach=" + bookTitleBLL.BookTitleId;
            DataTable dt = BookDAL._condb.getDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                List<BookBLL> bookList = new List<BookBLL>();
                foreach (DataRow row in dt.Rows)
                {
                    BookBLL bookBLL = new BookBLL(Int32.Parse(row["masach"].ToString()), Int32.Parse(row["madausach"].ToString()), Int32.Parse(row["matinhtrangsach"].ToString()));
                    bookList.Add(bookBLL);
                }
                return bookList;
            }
            return null;
            
        }
    }
}
