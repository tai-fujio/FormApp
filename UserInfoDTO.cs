using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApp
{
    public sealed class UserInfoDTO
    {
        public UserInfoDTO(
            string id,
            string mailSend,
            string mail,
            string plan,
            string enableText)

        {
            this.id = id;
            this.mailSend = mailSend;
            this.plan = plan;
            this.mail = mail;
            this.enableText = enableText;
        }

        public string id { get; }
        public string mailSend { get; }
        public string mail { get; }
        public string plan { get; }
        public string enableText { get; }
    }
}
