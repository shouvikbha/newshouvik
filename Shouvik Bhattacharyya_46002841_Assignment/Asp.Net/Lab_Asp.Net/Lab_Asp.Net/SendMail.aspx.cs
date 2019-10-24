using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
namespace Lab_Asp.Net
{
    public partial class SendMail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MailService mailService = new MailService();
            string fromId = (string)Session["userId"];
            bool sendMailStatus = mailService.SendMail(txtMailBody.Text, fromId, txtMailUName.Text, txtSubject.Text);
            if (sendMailStatus)
            {
                lblMessage.Text = "Mail Successfully sent";
                Response.Redirect("SendMail.aspx");
            }
            else
            {
                lblMessage.Text = "Error occured try again!";
                Response.Redirect("SendMail.aspx");
            }

        }
    }
}