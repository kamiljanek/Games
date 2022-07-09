using System;
using System.Net.Mail;

namespace RequestsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SmtpClient mailServer = new SmtpClient("smtp.gmail.com", 587);
                mailServer.EnableSsl = true;

                mailServer.Credentials = new System.Net.NetworkCredential("flymet.meteopress@gmail.com", "rduigygrntkffhfn");

                string from = "flymet.meteopress@gmail.com";
                string to = "flymet.meteopress@gmail.com";
                MailMessage msg = new MailMessage(from, to);
                msg.Subject = "Enter the subject here";
                msg.Body = "The message goes here.";
                msg.Attachments.Add(new Attachment(@"C:\Users\Kamil\Desktop\agnieszka\08.02.2022 23.14.14\Today - Precipitation - 3.png"));
                mailServer.Send(msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to send email. Error : " + ex);
            }

            Console.WriteLine("hello 1");
            Console.WriteLine("hello 2");



        }

    }
}
