using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MailsInBox
    {
        static int mailNo = 0;
        public MailsInBox()
        {
            mailNo++;
            MailTranNo = mailNo;
            MailDateTime = System.DateTime.Now;
        }
        public int MailTranNo { get; set; }

        public string FromMailUserId { get; set; }

        public string ToMailUserId { get; set; }

        public string Subject { get; set; }

        public string MailText { get; set; }

        public bool IsMailNew { get; set; } = true;

        public DateTime MailDateTime { get; set; }
    }
}
