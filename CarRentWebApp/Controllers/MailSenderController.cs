using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarRentWebApp.Controllers
{
    public class MailSenderController : Controller
    {
        public string SendEmail(string Email)
        {
            try
            {
                var credentials = new NetworkCredential("rentcarapposf@gmail.com", "!Dj96ain");

                var mail = new MailMessage()
                {
                    From = new MailAddress("client@yahoo.com"),
                    Subject = "Car rent information.",
                    Body = "Thank you for contacting us.How can we help you ?",
                };

                mail.IsBodyHtml = true;
                mail.To.Add(new MailAddress(Email));

                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.Send(mail);
                return "Email Sent Successfully!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}