using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MailService
    {
        public static List<MailUsers> mailUsers = new List<MailUsers>();
        public static List<MailsInBox> inbox = new List<MailsInBox>();

        public MailUsers SignIn(string Uname, string Password)
        {
            MailUsers user = null;
            user=(MailUsers) mailUsers.Where(c => c.MailUserName == Uname).FirstOrDefault(m=>m.MailUserPwd==Password);
            return user;
        }


        public bool SignUp(string mailUserName, string mailUserPwd, List<string> hobbies)
        {
            try
            {
                MailUsers newUser = new MailUsers();
                newUser.MailUserName = mailUserName;
                newUser.MailUserPwd = mailUserPwd;
                newUser.Hobbies = hobbies;
                newUser.AccountCreationDate = System.DateTime.Now;
                mailUsers.Add(newUser);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool SendMail(string mailText, string fromMailUserId, string toMailUserId, string subject)
        {
            MailsInBox newMail = new MailsInBox();
            newMail.FromMailUserId = fromMailUserId;
            newMail.ToMailUserId = toMailUserId;
            newMail.Subject = subject;
            newMail.MailText = mailText;
            try
            {
                inbox.Add(newMail);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<MailsInBox> GetMails(string Uid)
        {
            try
            {
                List<MailsInBox> allMails = inbox.Where(c => c.ToMailUserId == Uid).ToList();
                return allMails;
            }
            catch
            {
                return null;
            }

        }
    }
}
