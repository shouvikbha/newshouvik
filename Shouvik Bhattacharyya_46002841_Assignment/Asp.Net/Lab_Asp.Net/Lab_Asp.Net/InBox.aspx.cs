using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using System.Data;
namespace Lab_Asp.Net
{
    public partial class InBox : System.Web.UI.Page
    {
        List<MailsInBox> mails = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(Cache["mailList"]!=null)
            //{
            //    gridMailList.DataSource = Cache["mailList"];
            //    gridMailList.DataBind();
            //}
            //else
            //{
            //    string userId = (string)Session["userId"];
            //    MailService mailService = new MailService();
            //    List<MailsInBox> mails = mailService.GetMails(userId);
            //    Cache["mailList"] = mails;
            //    gridMailList.DataSource = mails;
            //    gridMailList.DataBind();                
            //}
            string userId = (string)Session["userId"];
            MailService mailService = new MailService();
            mails = mailService.GetMails(userId);
            Cache["mailList"] = mails;
            gridMailList.DataSource = mails;
            gridMailList.DataBind();
        }

        protected void gridMailList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            mails.RemoveAt(e.RowIndex);
            Cache["mailList"] = mails;
            gridMailList.DataSource = mails;
            gridMailList.DataBind();
        }
    }
}