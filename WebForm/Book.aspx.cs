using Core.BLL;
using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class Book : System.Web.UI.Page
    {
        public static int count = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session.Abandon();
            if (Session["readerId"]==null)
            {
                Response.Redirect("Reader.aspx");
            }
            if (!this.IsPostBack)
            {
                this.lblIdFirst.Text = "";
                this.lblIdSecond.Text = "";
                this.lblIdThird.Text = "";

                this.lblBookIdFirst.Text = "";
                this.lblBookIdSecond.Text = "";
                this.lblBookIdThird.Text = "";
                this.lblBookTitleFirst.Text = "";
                this.lblBookTitleSecond.Text = "";
                this.lblBookTitleThird.Text = "";
                this.btnRemoveFirst.Visible = false;
                this.btnRemoveSecond.Visible = false;
                this.btnRemoveThird.Visible = false;
            }
            this.lblReaderId.Text = Session["readerId"].ToString();
            this.lblReaderName.Text = Session["readerName"].ToString();
            this.lblQuantity.Text = Session["quantity"].ToString();
        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            BookTitleBLL bookTitleBLL = new BookTitleBLL();
            BorrowBookBLL borrowBLL = new BorrowBookBLL();
            if (ProcessGUI.IsNumeric(this.txtBookId.Text))
            {
                bookTitleBLL = borrowBLL.getBookTile(Int32.Parse(this.txtBookId.Text));
                if (bookTitleBLL != null)
                {
                    if (count <= Int32.Parse(Session["quantity"].ToString()))
                    {
                        if (count == 1)
                        {
                            this.lblBookTitleFirst.Text = bookTitleBLL.Name;
                            this.lblBookIdFirst.Text = bookTitleBLL.BookTitleId.ToString();
                            this.lblIdFirst.Text = this.txtBookId.Text;
                            count++;
                            Session["id1"] = this.txtBookId.Text;
                            Session["bookId1"] = this.lblBookIdFirst.Text;
                            Session["bookName1"] = this.lblBookTitleFirst.Text;
                            this.btnRemoveFirst.Visible = true;
                        }
                        else if (count == 2)
                        {
                            this.lblBookTitleSecond.Text = bookTitleBLL.Name;
                            this.lblBookIdSecond.Text = bookTitleBLL.BookTitleId.ToString();
                            this.lblIdSecond.Text = this.txtBookId.Text;
                            count++;

                            Session["id2"] = this.txtBookId.Text;
                            Session["bookId2"] = this.lblBookIdSecond.Text;
                            Session["bookName2"] = this.lblBookTitleSecond.Text;
                            this.btnRemoveSecond.Visible = true;
                        }
                        else if (count == 3)
                        {
                            this.lblBookTitleThird.Text = bookTitleBLL.Name;
                            this.lblBookIdThird.Text = bookTitleBLL.BookTitleId.ToString();
                            this.lblIdThird.Text = this.txtBookId.Text;
                            count++;
                            Session["id3"] = this.txtBookId.Text;
                            Session["bookId3"] = this.lblBookIdThird.Text;
                            Session["bookName3"] = this.lblBookTitleThird.Text;
                            this.btnRemoveThird.Visible = true;
                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        protected void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            this.lblBookIdFirst.Text = this.lblBookIdSecond.Text;
            this.lblBookTitleFirst.Text = this.lblBookTitleSecond.Text;
            this.lblBookIdSecond.Text = this.lblBookIdThird.Text;
            this.lblBookTitleSecond.Text = this.lblBookTitleThird.Text;
            this.lblBookIdThird.Text = " ";
            this.lblBookTitleThird.Text = " ";
            this.lblIdFirst.Text = this.lblIdSecond.Text;
            this.lblIdSecond.Text = this.lblIdThird.Text;
            this.lblIdThird.Text = "";
            if (this.btnRemoveSecond.Visible == true)
            {
                if (this.btnRemoveThird.Visible == true)
                {
                    this.btnRemoveThird.Visible = false;
                    Session["id1"] = Session["id2"];
                    Session["id2"] = Session["id3"];
                    Session.Remove("id3");
                    Session["bookId1"] = Session["bookId2"];
                    Session["bookId2"] = Session["bookId3"];
                    Session.Remove("bookId3");
                    Session["bookName1"] = Session["bookName2"];
                    Session["bookName2"] = Session["bookName3"];
                    Session.Remove("bookName3");
                    count--;
                }
                else
                {
                    this.btnRemoveSecond.Visible = false;
                    Session["bookId1"] = Session["bookId2"];
                    Session.Remove("book2");
                    Session["bookName1"] = Session["bookName2"];
                    Session.Remove("bookName2");
                    Session["id1"] = Session["id2"];
                    Session.Remove("id2");
                    count--;
                }
            }
            else
            {
                this.btnRemoveFirst.Visible = false;
                Session.Remove("bookId1");
                Session.Remove("bookName1");
                Session.Remove("id1");
                count--;
            }
        }

        protected void btnRemoveSecond_Click(object sender, EventArgs e)
        {
            this.lblBookIdSecond.Text = this.lblBookIdThird.Text;
            this.lblBookTitleSecond.Text = this.lblBookTitleThird.Text;
            this.lblBookIdThird.Text = " ";  
            this.lblBookTitleThird.Text = " ";
            this.lblIdSecond.Text = this.lblIdThird.Text;
            this.lblIdThird.Text = "";
            if (this.btnRemoveThird.Visible == true)
            {
                this.btnRemoveThird.Visible = false;
                Session["bookId2"] = Session["bookId3"];
                Session.Remove("bookId3");

                Session["bookName2"] = Session["bookName3"];
                Session.Remove("bookName3");

                Session["id2"] = Session["id3"];
                Session.Remove("id3");

                count--;
            }
            else
            {
                this.btnRemoveSecond.Visible = false;
                Session.Remove("bookId2");
                Session.Remove("bookName2");
                Session.Remove("id2");
                count--;
            }
        }

        protected void btnRemoveThird_Click(object sender, EventArgs e)
        {
            this.lblIdThird.Text = "";
            this.lblBookIdThird.Text = " ";
            this.lblBookTitleThird.Text = " ";
            this.btnRemoveThird.Visible = false;
            Session.Remove("bookId3");
            Session.Remove("bookName3");
            Session.Remove("id3");
            count--;
        }
    }
}