using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace StocksAndFinance
{
    public static class EmailSender
    {
        private static SmtpClient client = new SmtpClient();
        private static MailMessage message;
        public static void SendEmail(string _userEmail,string _message)
        {
            //set the smpt to be sent via the network
            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            //set up smtp to be sent via gmail with proper settings, ports, and password.
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Port = 587;
            client.Credentials = new NetworkCredential("Kevin.SMPT@gmail.com", "Testing@123");

            //set up message to be sent.
            MailAddress from = new MailAddress("Kevin.SMPT@gmail.com", "BotMailForProject");
            MailAddress to = new MailAddress(_userEmail, "Kevin Tran");
            message = new MailMessage(from, to);
        }
    }
}
