using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ServiceDeskController
{
   public class email
    {
        // set source email address as username
        private const string USERNAME = "inholland.best.team@gmail.com";
        //set password
        private const string PASSWORD = "Inholland5";
        //
        MailMessage mail;
        SmtpClient SmtpServer;

        public email()
        {
            //gmail SMTP server address
            SmtpServer = new SmtpClient("smtp.gmail.com");
            //set port
            SmtpServer.Port = 587;
            // detect SSL/TLS automatically
            SmtpServer.EnableSsl = true;
            // set delivery channel
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            //Gmail user authentication: sender username and password
            SmtpServer.Credentials = new System.Net.NetworkCredential(USERNAME, PASSWORD);

        }

        public  void IncidentBooked(string recipient)
        {
            string subject = $"Report Confirmation: ticket";
            string message = $"Thank you for getting in touch with us.We have forwared your problem to the technical team. Depending on the work load, we usally resolve all problems within 24hrs.if you have any questions, please do no hesitate to contact the helpdesk or the support team, use your ticket number  as reference";

            SendEmail(recipient, subject, message);
        }
        public void ProblemResolved (string recipient)
        {
            string subject = $"Issue Resolved:  ";
            string message = $"Issue  has been resolved. if you have any questions, please do no hesitate to contact the helpdesk or the support team, use your ticket number  as reference";

            SendEmail(recipient, subject, message);
        }
        private void SendEmail(string recipient, string subject, string message)
        {
            try
            {
                mail = new MailMessage();
                mail.From = new MailAddress(USERNAME);
                // set recipient email address
                mail.To.Add(recipient);
                //set  email subject
                mail.Subject = subject;
                // add message
                mail.Body = message;
                // send email
                SmtpServer.Send(mail);
                // destroy mail and server  objects
                mail.Dispose();
                SmtpServer.Dispose();
                //set mail is sent to true
            }
            catch (Exception ex)
            {
                //display error message

            }
        }

    }
}
