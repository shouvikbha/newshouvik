using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
namespace Lab_Asp.Net
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MailService mailService = new MailService();
            MailUsers user = mailService.SignIn(txtUserName.Text, txtPassword.Text);
            if (user!=null)
            {
                Session["userId"] = txtUserName.Text;
                if(user.Display=="tabular")
                    Response.Redirect("InBox.aspx");
                else
                    Response.Redirect("InBoxDetailsView.aspx");
            }
            else
            {
                lblMessage.Text = "Incorrect username and password";
                Response.Redirect("SignIn.aspx");
            }
        }
    }
}