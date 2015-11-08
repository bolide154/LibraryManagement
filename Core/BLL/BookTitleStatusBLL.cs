using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class BookTitleStatusBLL
    {
        private int bookTitleStatusId;
        private string name;

        public int BookTitleStatusId
        {
            get { return bookTitleStatusId; }
            set { bookTitleStatusId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public BookTitleStatusBLL(int _bookTitleStatusId, string _name)
        {
            this.bookTitleStatusId = _bookTitleStatusId;
            this.name = _name;
        }

        public BookTitleStatusBLL() { }

        
    }
}
