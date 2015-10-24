using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class TypeOfBookBLL
    {
        private int typeOfBookId;
        private string name;

        public int TypeOfBookId
        {
            get { return typeOfBookId; }
            set { typeOfBookId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public TypeOfBookBLL(int _typeOfBookId, string _name)
        {
            this.typeOfBookId = _typeOfBookId;
            this.name = _name;
        }

        public TypeOfBookBLL() { }

        public List<TypeOfBookBLL> LoadTypeOfBookList()
        {
            List<TypeOfBookBLL> typeOfBookArr = new List<TypeOfBookBLL>();
            TypeOfBookDAL typeOfBookDAL = new TypeOfBookDAL();
            DataTable dtTypeOfBook = new DataTable();
            dtTypeOfBook = typeOfBookDAL.LoadTypeOfBookList();
            foreach (DataRow row in dtTypeOfBook.Rows)
            {
                TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL();
                typeOfBookBLL.TypeOfBookId= Int32.Parse(row["matheloai"].ToString());
                typeOfBookBLL.Name = row["tentheloai"].ToString();
                typeOfBookArr.Add(typeOfBookBLL);
            }
            return typeOfBookArr;
        }

        public List<TypeOfBookBLL> Search(string catalog, string key)
        {
            List<TypeOfBookBLL> typeOfBookArr = new List<TypeOfBookBLL>();
            TypeOfBookDAL typeOfBookDAL = new TypeOfBookDAL();
            DataTable dtTypeOfBook = new DataTable();
            dtTypeOfBook = typeOfBookDAL.Search(catalog, key);
            foreach (DataRow row in dtTypeOfBook.Rows)
            {
                TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL();
                typeOfBookBLL.TypeOfBookId = Int32.Parse(row["matheloai"].ToString());
                typeOfBookBLL.Name = row["tentheloai"].ToString();
                typeOfBookArr.Add(typeOfBookBLL);
            }
            return typeOfBookArr;
        }

        public bool AddTypeOfBook(TypeOfBookBLL typeOfBookBLL)
        {
            TypeOfBookDAL typeOfBookDAL = new TypeOfBookDAL();
            return typeOfBookDAL.AddTypeOfBook(typeOfBookBLL);
        }

        public bool DeleteTypeOfBook(int id)
        {
            TypeOfBookDAL typeOfBookDAL = new TypeOfBookDAL();
            return typeOfBookDAL.DeleteTypeOfBook(id);
        }

        public bool UpdateTypeOfBook(TypeOfBookBLL typeOfBookBLL)
        {
            TypeOfBookDAL typeOfBookDAL = new TypeOfBookDAL();
            return typeOfBookDAL.UpdateTypeOfBook(typeOfBookBLL);
        }
    }
}
