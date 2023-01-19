using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
namespace University.Classes
{
    static class EmailSender
    {
        static private String _senderEmail = "322faul@gmail.com";
        static private String _senderPass = "opttyngqecbjqnyz";
        static public void sendEmail(String EmailGetter,String title, String text) {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(_senderEmail);
                message.To.Add(new MailAddress(EmailGetter));
                message.Subject = title;
                //message.IsBodyHtml = true; //to make message body as html
                message.Body = text;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(_senderEmail, _senderPass);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }
    }
}
