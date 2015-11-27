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
    public partial class BookGUI : Form
    {
        public BookGUI()
        {
            InitializeComponent();
        }

        private void BookGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToComBoBox();
        }

        private void LoadDataToComBoBox()
        {
            List<string> keyArr = new List<string>();
            keyArr.Add("Book Id");
            keyArr.Add("Book Title");
            keyArr.Add("Book Status");
            this.cboSearch.DataSource = keyArr;
        }
    }
}
