﻿using Core.BLL;
using System;
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
    public partial class TypeOfBookGUI : Form
    {
        public TypeOfBookGUI()
        {
            InitializeComponent();
        }

        private void TypeOfBookGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToComBoBox();
            this.LoadDataToGridView();
            this.GetSelectedValue();
        }

        private void LoadDataToComBoBox()
        {
            List<string> keyArr = new List<string>();
            keyArr.Add("Name");
            this.cboSearch.DataSource = keyArr;
            this.cboSearch.Text = "Serch by...";
        }

        private void LoadDataToGridView()
        {
                this.dgvTypeOfBook.Rows.Clear();
                TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL();
                List<TypeOfBookBLL> typeOfBookArr = new List<TypeOfBookBLL>();
                typeOfBookArr = typeOfBookBLL.LoadTypeOfBookList();
                foreach (TypeOfBookBLL row in typeOfBookArr)
                {
                    this.dgvTypeOfBook.Rows.Add(row.TypeOfBookId, row.Name);
                }
                this.GetSelectedValue();
                this.dgvTypeOfBook.CellClick += new DataGridViewCellEventHandler(this.dgvTypeOfBook_CellClick);
                
        }

        private void GetSelectedValue()
        {
            if (dgvTypeOfBook.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvTypeOfBook.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvTypeOfBook.Rows[selectedrowindex];

                string id = Convert.ToString(selectedRow.Cells["clmnId"].Value);
                string name = Convert.ToString(selectedRow.Cells["clmnName"].Value);
                this.lblInfor.Text = id + " / " + name;
                this.txtTypeOfBookName.Text = name;
                if (id == "")
                {
                    this.btnDelete.Enabled = false;
                    this.btnSave.Enabled = false;
                }
                else
                {
                    this.btnDelete.Enabled = true;
                    this.btnSave.Enabled = true;
                }
            }
            else
            {
                this.lblInfor.Text = "Id / Name";
                this.txtTypeOfBookName.Text = "";
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;
            }
        }

        private void dgvTypeOfBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string catalog = this.cboSearch.Text;
            string key = this.txtSearch.Text;
            if (key == "")
            {
                MessageBox.Show("Please enter keyword!", "Notice");
                return;
            }
            TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL();
            List<TypeOfBookBLL> typeOfBookArr = new List<TypeOfBookBLL>();
            typeOfBookArr = typeOfBookBLL.Search(catalog, key);
            this.dgvTypeOfBook.Rows.Clear();
            foreach (TypeOfBookBLL row in typeOfBookArr)
            {
                this.dgvTypeOfBook.Rows.Add(row.TypeOfBookId, row.Name);
            }

            this.GetSelectedValue();

            this.dgvTypeOfBook.CellClick += new DataGridViewCellEventHandler(dgvTypeOfBook_CellClick);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL();
                typeOfBookBLL.Name = this.txtTypeOfBookName.Text;
                if (typeOfBookBLL.Name == "")
                {
                    MessageBox.Show("Author name is not null!", "Notice");
                    return;
                }
                if (typeOfBookBLL.AddTypeOfBook(typeOfBookBLL))
                {
                    MessageBox.Show("Add success!", "Success");
                }
                else
                {
                    MessageBox.Show("Fail!", "Error");
                }
                this.LoadDataToGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvTypeOfBook.SelectedCells.Count > 0)
            {
                int selectedrowindex = this.dgvTypeOfBook.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dgvTypeOfBook.Rows[selectedrowindex];
                int id = Convert.ToInt32(selectedRow.Cells["clmnId"].Value);
                DialogResult result = MessageBox.Show("Do you want to delete type of book: " + selectedRow.Cells["clmnName"].Value + "?", "Warning", MessageBoxButtons.OKCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        break;
                    case DialogResult.OK:
                        TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL();
                        if (!typeOfBookBLL.CheckDelete(id))
                        {
                            MessageBox.Show("Can't delete! Please delete all book title has type " + selectedRow.Cells["clmnName"].Value + " before delete this type!", "Error");
                            break;
                        }
                        else
                        {
                            if (typeOfBookBLL.DeleteTypeOfBook(id))
                            {
                                MessageBox.Show("Delete complete!", "Success");
                            }
                            else
                            {
                                MessageBox.Show("Fail!", "Error");
                            }
                            this.LoadDataToGridView();
                            break;
                        }
                }
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.dgvTypeOfBook.SelectedCells.Count > 0)
            {

                int selectedrowindex = this.dgvTypeOfBook.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvTypeOfBook.Rows[selectedrowindex];

                TypeOfBookBLL typeOfBookBLL = new TypeOfBookBLL();
                typeOfBookBLL.TypeOfBookId = Convert.ToInt32(selectedRow.Cells["clmnId"].Value);
                typeOfBookBLL.Name = txtTypeOfBookName.Text;
                if (typeOfBookBLL.Name == "")
                {
                    MessageBox.Show("Author name is not null!", "Notice");
                    return;
                }
                if (typeOfBookBLL.UpdateTypeOfBook(typeOfBookBLL))
                {
                    MessageBox.Show("Update success!", "Success");
                }
                else
                {
                    MessageBox.Show("Fail", "Error");
                }
                this.LoadDataToGridView();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


    }
}
