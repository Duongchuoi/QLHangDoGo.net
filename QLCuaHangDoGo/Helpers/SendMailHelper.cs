using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangDoGo.Helpers
{
    public class SendMessage
    {
        public string Destination { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
    public class SendMailHelper
    {
        public static bool SendMail(SendMessage message)
        {

            var mailSettings = new MailSettings();
            var email = new MimeMessage();
            email.Sender = new MailboxAddress(mailSettings.DisplayName, mailSettings.Mail);
            email.From.Add(new MailboxAddress(mailSettings.DisplayName, mailSettings.Mail));
            email.To.Add(MailboxAddress.Parse(message.Destination));
            email.Subject = message.Subject;

            var builder = new BodyBuilder
            {
                HtmlBody = message.Body
            };
            email.Body = builder.ToMessageBody();

            var smtp = new MailKit.Net.Smtp.SmtpClient();

            try
            {
                smtp.Connect(mailSettings.Host, mailSettings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(mailSettings.Mail, mailSettings.Password);
                smtp.Send(email);
                smtp.Disconnect(true);
                return true;
            }
            catch
            {
                return false;
            }

        }

    }

    public class MailSettings
    {
        public string Host { get; set; } = ConfigurationManager.AppSettings["Host"];
        public int Port { get; set; } = int.Parse(ConfigurationManager.AppSettings["Port"]);
        public string DisplayName { get; set; } = ConfigurationManager.AppSettings["DisplayName"];
        public string Mail { get; set; } = ConfigurationManager.AppSettings["Mail"];
        public string Password { get; set; } = ConfigurationManager.AppSettings["Password"];

    }
}
