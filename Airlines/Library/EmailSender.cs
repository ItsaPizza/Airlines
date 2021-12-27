using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class EmailSender
    {
        //public void MailSender()
        //{
        //    MailAddress to = new MailAddress("laurynas.balsys91@gmail.com");
        //    MailAddress from = new MailAddress("laurynas.balsys91@gmail.com");

        //    MailMessage message = new MailMessage(from, to);
        //    message.Subject = "Good morning, Elizabeth";
        //    message.Body = "Elizabeth, Long time no talk. Would you be up for lunch in Soho on Monday? I'm paying.;";

        //    SmtpClient client = new SmtpClient("smtp.server.address", 2525)
        //    {
        //        Credentials = new NetworkCredential("smtp_username", "smtp_password"),
        //        EnableSsl = true
        //    };
        //}

            //public void Sent()
            //{
            //    MailAddress to = new MailAddress("laurynas.balsys91@gmail.com");
            //    MailAddress from = new MailAddress("laurynas.balsys91@gmail.com");

            //    MailMessage message = new MailMessage(to, from);
            //    message.Subject = "x";
            //    message.Body = "y";

            //    SmtpClient client = new SmtpClient("smtp.server.address", 2525)
            //    {
            //        Credentials = new NetworkCredential("smtp_username", "smtp_password"),
            //        EnableSsl = true
            //    };
            //}

        public void Sent(string title, string body)
        {
            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("858f07ff9e9a7f", "41a5a05ac4f813"),
                EnableSsl = true
            };
            client.Send("laurynas.balsys91@gmail.com", "laurynas.balsys91@gmail.com", title, body);
            Console.WriteLine("Sent");
            Console.ReadLine();
        }
        
    }
}
