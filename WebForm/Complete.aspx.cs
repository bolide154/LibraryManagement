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
    public partial class Complete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["readerId"] == null)
            {
                Response.Redirect("Reader.aspx");
            }
            if (!this.IsPostBack)
            {
                if (Session["bookId1"] != null)
                {
                    if (Session["bookId2"] != null)
                    {
                        if (Session["bookId3"] != null)
                        {
                            this.lblIdFirst.Text = Session["id1"].ToString();
                            this.lblIdSecond.Text = Session["id2"].ToString();
                            this.lblIdThird.Text = Session["id3"].ToString();

                            this.lblBookIdFirst.Text = Session["bookId1"].ToString();
                            this.lblBookIdSecond.Text = Session["bookId2"].ToString();
                            this.lblBookIdThird.Text = Session["bookId3"].ToString();
                            

                            this.lblBookTitleFirst.Text = Session["bookName1"].ToString();
                            this.lblBookTitleSecond.Text = Session["bookName2"].ToString();
                            this.lblBookTitleThird.Text = Session["bookName3"].ToString();
                        }
                        else
                        {
                            this.lblIdFirst.Text = Session["id1"].ToString();
                            this.lblIdSecond.Text = Session["id2"].ToString();
                            this.lblIdThird.Text = "";

                            this.lblBookIdFirst.Text = Session["bookId1"].ToString();
                            this.lblBookIdSecond.Text = Session["bookId2"].ToString();
                            this.lblBookIdThird.Text = "";
                            

                            this.lblBookTitleFirst.Text = Session["bookName1"].ToString();
                            this.lblBookTitleSecond.Text = Session["bookName2"].ToString();
                            this.lblBookTitleThird.Text = "";
                        }
                    }
                    else
                    {
                        this.lblIdFirst.Text = Session["id1"].ToString();
                        this.lblIdSecond.Text = "";
                        this.lblIdThird.Text = "";

                        this.lblBookIdFirst.Text = Session["bookId1"].ToString();
                        this.lblBookIdSecond.Text = "";
                        this.lblBookIdThird.Text = "";

                        this.lblBookTitleFirst.Text = Session["bookName1"].ToString();
                        this.lblBookTitleSecond.Text = "";
                        this.lblBookTitleThird.Text = "";
                    }
                }
                else
                {
                    Response.Redirect("Book.aspx");
                }
            }
            this.lblReaderId.Text = Session["readerId"].ToString();
            this.lblReaderName.Text = Session["readerName"].ToString();
            this.lblQuantity.Text = Session["quantity"].ToString();
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Int64 readerId = Int64.Parse(Session["ReaderId"].ToString());
            DateTime dateAdded = DateTime.Now;
            DateTime dateEnd = dateAdded.AddDays(10);
            List<Int32> bookList = new List<Int32>();
            if (Session["bookId1"] != null)
            {
                if (Session["bookId2"] != null)
                {
                    if (Session["bookId3"] != null)
                    {
                        bookList.Add(Int32.Parse(Session["bookId1"].ToString()));
                        bookList.Add(Int32.Parse(Session["bookId2"].ToString()));
                        bookList.Add(Int32.Parse(Session["bookId3"].ToString()));
                    }
                    else
                    {
                        bookList.Add(Int32.Parse(Session["bookId1"].ToString()));
                        bookList.Add(Int32.Parse(Session["bookId2"].ToString()));
                    }
                }
                else
                {
                    bookList.Add(Int32.Parse(Session["bookId1"].ToString()));
                }
            }
            else
            {
                Response.Redirect("Book.aspx");
            }
            CertificateBLL certificateBLL = new CertificateBLL(1, readerId, dateAdded, dateEnd);
            BorrowBookBLL borrowBookBLL = new BorrowBookBLL();
            try
            {
                borrowBookBLL.Add(certificateBLL, bookList);
                string script = "alert(\"Success!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                this.btnConfirm.Visible = false;
                this.btnCancel.Visible = false;
                Session.Abandon();
                //Response.Redirect("Reader.aspx");
            }
            catch (Exception ex) 
            {
                string script = "alert(\"Error while add certificate: "+ex.Message+"\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Reader.aspx");
        }
    }
}