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
    public partial class index : System.Web.UI.Page
    {
        ReaderBLL _readerBLL = new ReaderBLL();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["readerName"] = null;
            Session["readerId"] = null;
            Session["quantity"] = null;
            this.lblReaderId.Text = "";
            this.lblReaderName.Text = "";
            this.lblReaderId.Text = "";
            this.lblEmail.Text = "";
            this.lblAddress.Text = "";
            this.lblDayOfBirth.Text = "";
            this.lblPhone.Text = "";
            this.lblStatus.Text = "";
            this.lblQuantity.Text = "";
            
            this.DataBind();
        }

        protected void AddReader_Click(object sender, EventArgs e)
        {
            if (ProcessGUI.IsNumeric(this.txtReaderId.Text))
            {
                Int64 readerId = Int64.Parse(this.txtReaderId.Text);
                ReaderBLL readerBLL = new ReaderBLL();
                readerBLL = ReaderDAL.getReaderByReaderId(readerId);
                this._readerBLL = readerBLL;
                if (readerBLL != null)
                {
                    this.lblReaderName.Text = readerBLL.Name;
                    this.lblReaderId.Text = readerBLL.Code.ToString();
                    this.lblEmail.Text = readerBLL.Email;
                    this.lblAddress.Text = readerBLL.Address;
                    this.lblDayOfBirth.Text = readerBLL.Birthday.ToShortDateString();
                    this.lblPhone.Text = readerBLL.Phone;
                    this.lblQuantity.Text = "0";

                    int result = (DateTime.Compare(DateTime.Now, readerBLL.Enddate));
                    if (result > 0)
                    {
                        string script = "alert(\"This reader has expired!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                        this.lblStatus.Text = "Expired";
                    }
                    else
                    {
                        BorrowBookBLL borrowBookBLL = new BorrowBookBLL();
                        if (borrowBookBLL.checkBookBorrowMax(readerBLL))
                        {
                            this.lblStatus.Text = "Good";
                            Session["readerName"]= readerBLL.Name;
                            Session["readerId"] = readerBLL.Code;
                            Session["quantity"] = borrowBookBLL.getBookQuantityCanBorrow(readerBLL);
                            this.lblQuantity.Text = borrowBookBLL.getBookQuantityCanBorrow(readerBLL).ToString();
                            
                        }
                        else
                        {
                            string script = "alert(\"Reader has  borrowed maximum books!\");";
                            ScriptManager.RegisterStartupScript(this, GetType(),
                                                  "ServerControlScript", script, true);
                            this.lblStatus.Text = "Maximum";
                        }
                    }
                }
                else
                {
                    string script = "alert(\"Readers do not exist!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                }
            }
        }
    }

    public static class ProcessGUI
    {
        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
    }
}