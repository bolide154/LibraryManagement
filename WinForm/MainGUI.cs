﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        private void mnuiInfor_Click(object sender, EventArgs e)
        {
            AuthorGUI authorGUI = new AuthorGUI();
            authorGUI.Show();
        }

        private void mnuiTypeOfBook_Click(object sender, EventArgs e)
        {
            TypeOfBookGUI typeOfBookGUI = new TypeOfBookGUI();
            typeOfBookGUI.Show();
        }
    }
}
