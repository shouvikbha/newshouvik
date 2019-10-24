using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MailUsers
    {
        static int mailId = 0;
        public MailUsers()
        {
            mailId++;
            MailUserId = mailId.ToString();
        }
        public string MailUserId { get; set; }

        public string MailUserName { get; set; }

        public string MailUserPwd { get; set; }

        public DateTime AccountCreationDate { get; set; }

        public List<string> Hobbies { get; set; }

        public string Display { get; set; } = "tabular";
    }
}
