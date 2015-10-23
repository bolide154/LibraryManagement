using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class AuthorBLL
    {
        int authorId;
        string name;
        string workPlace;

        public int AuthorId
        {
            get { return authorId; }
            set { authorId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string WorkPlace
        {
            get { return workPlace; }
            set { workPlace = value; }
        }

        public AuthorBLL(int _authorId, string _name, string _workPlace)
        {
            this.authorId = _authorId;
            this.name = _name;
            this.workPlace = _workPlace;
        }

        public AuthorBLL() { }

        public List<AuthorBLL> LoadAuthorList()
        {
            List<AuthorBLL> authorArr = new List<AuthorBLL>();
            AuthorDAL authorDAL = new AuthorDAL();
            DataTable dtAuthor = new DataTable();
            dtAuthor = authorDAL.LoadAuthorList();
            foreach (DataRow row in dtAuthor.Rows)
            {
                AuthorBLL authorBLL = new AuthorBLL();
                authorBLL.AuthorId = Int32.Parse(row["matacgia"].ToString());
                authorBLL.Name = row["tentacgia"].ToString();
                authorBLL.WorkPlace = row["noicongtac"].ToString();
                authorArr.Add(authorBLL);
            }
            return authorArr;
        }
        public bool AddAuthor(AuthorBLL authorBLL) {
            AuthorDAL authorDAL = new AuthorDAL();
            return authorDAL.AddAuthor(authorBLL);
        }
        public bool DeleteAuthor(int id)
        {
            AuthorDAL authorDAL = new AuthorDAL();
            return authorDAL.DeleteAuthor(id);
        }
        public bool UpdateAuthor(AuthorBLL authorBLL)
        {
            AuthorDAL authorDAL = new AuthorDAL();
            return authorDAL.UpdateAuthor(authorBLL);
        }

        public List<AuthorBLL> Search(string catalog, string key)
        {
            List<AuthorBLL> authorArr = new List<AuthorBLL>();
            AuthorDAL authorDAL = new AuthorDAL();
            DataTable dtAuthor = new DataTable();
            dtAuthor = authorDAL.Search(catalog, key);
            foreach (DataRow row in dtAuthor.Rows)
            {
                AuthorBLL authorBLL = new AuthorBLL();
                authorBLL.AuthorId = Int32.Parse(row["matacgia"].ToString());
                authorBLL.Name = row["tentacgia"].ToString();
                authorBLL.WorkPlace = row["noicongtac"].ToString();
                authorArr.Add(authorBLL);
            }
            return authorArr;
        }
    }
}
