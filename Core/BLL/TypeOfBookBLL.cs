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
    }
}
