using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
namespace Lab_Asp.Net
{
    public partial class ShowMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int mailId = Convert.ToInt32(Request.QueryString["MailTranNo"]);
            List<MailsInBox> mails = Cache["mailList"] as List<MailsInBox>;
            MailsInBox mail = mails.Find(m => m.MailTranNo == mailId);
            Response.Write("From Mail User:" + mail.FromMailUserId+Environment.NewLine);
            Response.Write("Subject:" + mail.Subject+Environment.NewLine);
            Response.Write("Mail Body:"+mail.MailText+Environment.NewLine);
        }
    }
}