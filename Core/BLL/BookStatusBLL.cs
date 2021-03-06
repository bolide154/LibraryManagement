﻿using Core.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BLL
{
    public class BookStatusBLL
    {
        private int _bookStatusId;
        private string _name;

        public int BookStatusId
        {
            get { return _bookStatusId; }
            set { _bookStatusId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public BookStatusBLL(int _bookStatusId, string _name)
        {
            this._bookStatusId = _bookStatusId;
            this._name = _name;
        }

        public BookStatusBLL() { }
    }
}
