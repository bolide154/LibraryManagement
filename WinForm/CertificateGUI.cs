using Core.BLL;
using Core.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WinForm
{
    public partial class CertificateGUI : Form
    {
        public CertificateGUI()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            this.dgvCertificateStt.Rows.Clear();
            CertificateBLL manageCertificateBLL = new CertificateBLL();
            List<CertificateBLL> manageCertificateArr = new List<CertificateBLL>();
            manageCertificateArr = CertificateDAL.getManageCertificateList();
            //MessageBox.Show("ok");
            foreach (CertificateBLL row in manageCertificateArr)
            {
                this.dgvCertificateStt.Rows.Add(row.Idphieumuon, row.Tentinhtrang,row.Ngaymuon, row.Hantra, row.Tendocgia, row.Lacnvc, row.Iddocgia);
            }
            this.GetSelectedValue();
            this.dgvCertificateStt.SelectionChanged += new EventHandler(dgvCertificateStt_SelectionChanged);
        }

        private void dgvCertificateStt_SelectionChanged(object sender, EventArgs e)
        {
            this.GetSelectedValue();
        }

        private void GetSelectedValue()
        {
            if (this.dgvCertificateStt.SelectedCells.Count > 0 && this.dgvCertificateStt.CurrentRow.Index < this.dgvCertificateStt.Rows.Count - 1)
            {
                int selectedrowindex = this.dgvCertificateStt.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = this.dgvCertificateStt.Rows[selectedrowindex];
                DateTime current = new DateTime();
                DateTime endtime = new DateTime();
                TimeSpan tg;
                string name = Convert.ToString(selectedRow.Cells["clmnReaderName"].Value);
                bool ob = Convert.ToBoolean(selectedRow.Cells["clmnObject"].Value);
                string id = Convert.ToString(selectedRow.Cells["clmnReaderCode"].Value);
                DateTime daystart = Convert.ToDateTime(selectedRow.Cells["clmnDayStart"].Value);
                DateTime dayend = Convert.ToDateTime(selectedRow.Cells["clmnDayEnd"].Value);
                current = DateTime.Now;
                endtime = Convert.ToDateTime(selectedRow.Cells["clmnDayEnd"].Value);
                tg = endtime - current;
                this.txtReaderName.Text = name;
                this.txtReaderCode.Text = id;
                this.txtDayStart.Text = daystart.ToShortDateString();
                this.txtDayEnd.Text = dayend.ToShortDateString();
                if(ob)
                {
                    this.txtObject.Text = "Cán Bộ Công Nhân Viên";
                }
                else
                {
                    this.txtObject.Text = "Sinh Viên";
                }
                int songay = Convert.ToInt16(tg.Days);
                if (songay < 0)
                {
                    if (selectedRow.Cells["clmnStt"].Value.ToString() != "mới tạo")
                    {
                        this.txtOutOfDay.Text = "";
                    }
                    else
                    {
                        this.txtOutOfDay.Text = "trễ " + Math.Abs(songay) + " ngày";
                    }
                }
                /*if (id == "")
                {
                    this.btnDelete.Enabled = false;
                    this.btnSave.Enabled = false;
                }
                else
                {
                    this.btnDelete.Enabled = true;
                    this.btnSave.Enabled = true;
                }*/
                if (this.dgvCertificateStt.SelectedCells.Count > 0 && this.dgvCertificateStt.CurrentRow.Index < this.dgvCertificateStt.Rows.Count - 1)
                {
                    this.dgvDetailCertificate.Rows.Clear();
                    DetailCertificateBLL manageCertificateBLL = new DetailCertificateBLL();
                    List<DetailCertificateBLL> manageCertificateArr = new List<DetailCertificateBLL>();
                    manageCertificateArr = CertificateDAL.getDetailCertificateList(Convert.ToInt32(selectedRow.Cells["clmnId"].Value));
                    //MessageBox.Show("ok");
                    foreach (DetailCertificateBLL row in manageCertificateArr)
                    {
                        this.dgvDetailCertificate.Rows.Add(row.Masach, row.Tensach);
                    }
                }
            }
            else
            {
                this.txtReaderName.Text = "";
                this.txtReaderCode.Text = "";
                this.txtDayStart.Text = "";
                this.txtDayEnd.Text = "";
                this.txtObject.Text = "";
                this.txtOutOfDay.Text = "";
                this.dgvDetailCertificate.Rows.Clear();
            }
        }
        private void ManageCertificateGUI_Load(object sender, EventArgs e)
        {
            this.LoadDataToGridView();
            this.loadDataToComboBoxCertificate();
            this.GetSelectedValue();
            this.dgvCertificateStt.CellClick += new DataGridViewCellEventHandler(dgvCertificateStt_SelectionChanged);
        }

        private void loadDataToComboBoxCertificate()
        {
            List<string> keyname = new List<string>();
            keyname.Add("Certificate");
            keyname.Add("Certificate Stt");
            this.cboSearch.DataSource = keyname;
        }
        private void dgvCertificateStt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GetSelectedValue();
            //MessageBox.Show(dgvCertificateStt.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //this.getDetailCertificate(dgvCertificateStt_SelectionChanged);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = this.txtSearch.Text;
            if (key == "".Trim())
            {
                MessageBox.Show("Please enter keyword!", "Notice");
                return;
            }
            string catalog = "";
            //MessageBox.Show(this.cboSearch.SelectedItem.ToString());
            if (this.cboSearch.SelectedItem.ToString() == "Certificate")
            {
                catalog+= "phieumuon.maphieumuon";
                //MessageBox.Show(catalog);
            }
            else if (this.cboSearch.SelectedItem.ToString() == "Certificate Stt")
            {
                catalog+= "tinhtrangphieumuon.tentinhtrang";
                //MessageBox.Show(catalog);
            }
            CertificateBLL bookStatusBLL = new CertificateBLL();
            List<CertificateBLL> certificateStatusArr = new List<CertificateBLL>();
            certificateStatusArr = CertificateDAL.search(key,catalog);
            this.dgvCertificateStt.Rows.Clear();
            if (certificateStatusArr != null)
            {
                //MessageBox.Show("ok");
                foreach (CertificateBLL row in certificateStatusArr)
                {
                    this.dgvCertificateStt.Rows.Add(row.Idphieumuon, row.Tentinhtrang, row.Ngaymuon, row.Hantra, row.Tendocgia, row.Lacnvc, row.Iddocgia);
                }
            }
            else
            {
                MessageBox.Show("Sorry! Can't find this certificate");
                return;
            }
            this.GetSelectedValue();
            this.dgvCertificateStt.SelectionChanged += new EventHandler(dgvCertificateStt_SelectionChanged);
        }
        /*public class ExcelWriter
        {
            private Stream stream;
            private BinaryWriter writer;

            private ushort[] clBegin = { 0x0809, 8, 0, 0x10, 0, 0 };
            private ushort[] clEnd = { 0x0A, 00 };


            private void WriteUshortArray(ushort[] value)
            {
                for (int i = 0; i < value.Length; i++)
                    writer.Write(value[i]);
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="ExcelWriter"/> class.
            /// </summary>
            /// <param name="stream">The stream.</param>
            public ExcelWriter(Stream stream)
            {
                this.stream = stream;
                writer = new BinaryWriter(stream);
            }

            /// <summary>
            /// Writes the text cell value.
            /// </summary>
            /// <param name="row">The row.</param>
            /// <param name="col">The col.</param>
            /// <param name="value">The string value.</param>
            public void WriteCell(int row, int col, string value)
            {
                ushort[] clData = { 0x0004, 0, 0, 0, 0, 0 };
                int iLen = value.Length;
                byte[] plainText = Encoding.UTF8.GetBytes(value);
                clData[1] = (ushort)(10 + iLen);
                clData[2] = (ushort)row;
                clData[3] = (ushort)col;
                clData[5] = (ushort)iLen;
                WriteUshortArray(clData);
                writer.Write(plainText);
            }

            /// <summary>
            /// Writes the integer cell value.
            /// </summary>
            /// <param name="row">The row number.</param>
            /// <param name="col">The column number.</param>
            /// <param name="value">The value.</param>
            public void WriteCell(int row, int col, int value)
            {
                ushort[] clData = { 0x027E, 10, 0, 0, 0 };
                clData[2] = (ushort)row;
                clData[3] = (ushort)col;
                WriteUshortArray(clData);
                int iValue = (value << 2) | 2;
                writer.Write(iValue);
            }

            /// <summary>
            /// Writes the double cell value.
            /// </summary>
            /// <param name="row">The row number.</param>
            /// <param name="col">The column number.</param>
            /// <param name="value">The value.</param>
            public void WriteCell(int row, int col, double value)
            {
                ushort[] clData = { 0x0203, 14, 0, 0, 0 };
                clData[2] = (ushort)row;
                clData[3] = (ushort)col;
                WriteUshortArray(clData);
                writer.Write(value);
            }

            /// <summary>
            /// Writes the empty cell.
            /// </summary>
            /// <param name="row">The row number.</param>
            /// <param name="col">The column number.</param>
            public void WriteCell(int row, int col)
            {
                ushort[] clData = { 0x0201, 6, 0, 0, 0x17 };
                clData[2] = (ushort)row;
                clData[3] = (ushort)col;
                WriteUshortArray(clData);
            }

            /// <summary>
            /// Must be called once for creating XLS file header
            /// </summary>
            public void BeginWrite()
            {
                WriteUshortArray(clBegin);
            }

            /// <summary>
            /// Ends the writing operation, but do not close the stream
            /// </summary>
            public void EndWrite()
            {
                WriteUshortArray(clEnd);
                writer.Flush();
            }
        }
        public void ExportExcel()
        {
            using (StreamWriter stream = new StreamWriter(@"D:\demo.xls", true, Encoding.Unicode))
            {
               
                stream.Write(string.Format(""))
                for (int i = 1; i <= this.dgvCertificateStt.Rows.Count; i++)
                {
                    stream.WriteLine(string.Concat(this.dgvCertificateStt.Rows[1].Cells["clmnId"].Value.ToString(), ",", this.dgvCertificateStt.Rows[1].Cells["clmnStt"].Value.ToString()));
                }
                stream.Flush();
                stream.Close();
            }
            
            /*for (int i = 1; i <= this.dgvCertificateStt.Rows.Count; i++)
            {
                writer.WriteCell(i, 0, this.dgvCertificateStt.Rows[1].Cells["clmnId"].Value.ToString());
                writer.WriteCell(i, 1, this.dgvCertificateStt.Rows[1].Cells["clmnStt"].Value.ToString());
            }
            writer.EndWrite();
            stream.Close();*/
        //MessageBox.Show(this.dgvCertificateStt.Rows[1].Cells["clmnId"].Value.ToString());
        //var exl = new excel
        //}

        /*private void btnExportEx_Click(object sender, EventArgs e)
        {
            this.ExportExcel();
        }*/
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";


            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + dGV.Rows[i].Cells[j].Value.ToString() + "\t";
                stOutput += stLine + "\r\n";
            }
            FileStream fs = new FileStream(filename, FileMode.Create);
            StreamWriter bw = new StreamWriter(fs, Encoding.Unicode);
            bw.Write(stOutput); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private void btnExportEx_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Certificate.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(this.dgvCertificateStt, sfd.FileName);
                //ToCsV(nHANVIEN_DTODataGridView, sfd.FileName); // Here dataGridview1 is your grid view name 
            }
        }
    }
}
