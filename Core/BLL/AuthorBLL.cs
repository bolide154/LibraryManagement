using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    class AuthorBLL
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

    }
}
