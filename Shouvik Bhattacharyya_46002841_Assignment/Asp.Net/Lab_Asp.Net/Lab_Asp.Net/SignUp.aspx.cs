using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
namespace Lab_Asp.Net
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            MailService mailService = new MailService();
            List<String> Hobbies = new List<String>();
            foreach (ListItem item in chkHobbies.Items)
            {
                if (item.Selected)
                    Hobbies.Add(item.Value);
            }
            bool registrationStatus = mailService.SignUp(txtMailUserName.Text, txtPassword.Text, Hobbies);
            if (registrationStatus)
            {
                Response.Redirect("SignIn.aspx");
            }
            else
            {
                lblMessage.Text = "Registration failed";
                Response.Redirect("SignUp.aspx");
            }
        }
    }
}