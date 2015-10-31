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
        int _authorId;
        string _name;
        string _workPlace;

        public int AuthorId
        {
            get { return _authorId; }
            set { _authorId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string WorkPlace
        {
            get { return _workPlace; }
            set { _workPlace = value; }
        }

        public AuthorBLL(int authorId, string name, string workPlace)
        {
            this._authorId = authorId;
            this._name = name;
            this._workPlace = workPlace;
        }

        public AuthorBLL() { }

        public List<AuthorBLL> LoadAuthorList()
        {
            return AuthorDAL.LoadAuthorList();
        }
        public bool AddAuthor(AuthorBLL authorBLL) {
            return AuthorDAL.AddAuthor(authorBLL);
        }
        public bool DeleteAuthor(AuthorBLL authorBLL)
        {

            return AuthorDAL.DeleteAuthor(authorBLL);
        }
        public bool UpdateAuthor(AuthorBLL authorBLL)
        {
            return AuthorDAL.UpdateAuthor(authorBLL);
        }

        public List<AuthorBLL> Search(string key, string value)
        {
			return AuthorDAL.Search(key, value);
        }

        public bool CheckDelete(AuthorBLL authorBLL)
        {
            return AuthorDAL.CheckDelete(authorBLL);
        }
    }
}
