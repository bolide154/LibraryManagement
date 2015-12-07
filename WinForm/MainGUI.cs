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

        private void mnuiPublisher_Click(object sender, EventArgs e)
        {
            PublisherGUI publisherGUI = new PublisherGUI();
            publisherGUI.Show();
        }

        private void mnuiBookTitleStatus_Click(object sender, EventArgs e)
        {
            BookTitleStatusGUI bookTitleStatusGUI = new BookTitleStatusGUI();
            bookTitleStatusGUI.Show();
        }

        private void mnuiStatus_Click(object sender, EventArgs e)
        {
            BookStatusGUI bookStatusGUI = new BookStatusGUI();
            bookStatusGUI.Show();
        }

        private void mnuiBookTitle_Click(object sender, EventArgs e)
        {
            BookTitleGUI bookTitleGUI = new BookTitleGUI();
            bookTitleGUI.Show();
        }

        private void mnuReader_Click(object sender, EventArgs e)
        {
            ReaderGUI reader = new ReaderGUI();
            reader.Show();
        }

        private void mnuiCertificateStt_Click(object sender, EventArgs e)
        {
            AspectCertificateGUI certificate = new AspectCertificateGUI();
            certificate.Show();
        }

        private void certificateManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CertificateGUI certificate = new CertificateGUI();
            certificate.Show();
        }

        private void voucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoucherGUI voucher = new VoucherGUI();
            voucher.Show();
        }
    }
}
