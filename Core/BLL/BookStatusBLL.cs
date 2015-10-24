using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class BookStatusBLL
    {
        private int bookStatusId;
        private string name;

        public int BookStatusId
        {
            get { return bookStatusId; }
            set { bookStatusId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public BookStatusBLL(int _bookStatusId, string _name)
        {
            this.bookStatusId = _bookStatusId;
            this.name = _name;
        }

        public BookStatusBLL() { }

        
    }
}
