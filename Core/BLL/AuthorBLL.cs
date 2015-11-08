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

        
    }
}
