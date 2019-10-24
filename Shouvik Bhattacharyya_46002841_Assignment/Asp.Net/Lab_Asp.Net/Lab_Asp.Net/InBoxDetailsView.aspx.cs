using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
namespace Lab_Asp.Net
{
    public partial class InBoxDetailsView : System.Web.UI.Page
    {
        List<MailsInBox> mails = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string userId = (string)Session["userId"];
            MailService mailService = new MailService();
            mails = mailService.GetMails(userId);
            Cache["mailList"] = mails;
            DetailsView1.DataSource = mails;
            DetailsView1.DataBind();
                       
        }

        protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
        {
            mails.RemoveAt(e.RowIndex);
            Cache["mailList"] = mails;
            DetailsView1.DataSource = mails;
            DetailsView1.DataBind();
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DetailsView1.PageIndex = e.NewPageIndex;
            Cache["mailList"] = mails;
            DetailsView1.DataSource = mails;
            DetailsView1.DataBind();
        }
    }
}