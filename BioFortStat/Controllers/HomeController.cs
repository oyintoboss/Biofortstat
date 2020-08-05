using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(string name, string email, string subject, string message)
        {
            // ViewBag.Message = "Your contact page.";

           // var senderEmail = new MailAddress("oluwatobaisreal@gmail.com", "Demo.Testszz");
            var senderEmail = new MailAddress(ConfigurationManager.AppSettings["senderEmail"].ToString(), ConfigurationManager.AppSettings["senderTopic"].ToString());
            var receiveremail = new MailAddress(email, "Receiver");

           // var password = "DTHES-TEKH@11";
            var password = ConfigurationManager.AppSettings["password"].ToString();
            var sub = subject;
            var body = message;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                // UseDefaultCredentials = true,
                Credentials = new NetworkCredential(senderEmail.Address, password)
            };

            using (var msg = new MailMessage(senderEmail, receiveremail)
            {
                Subject = subject,
                Body = body
            })
            {
                //// Send: 
                try
                {
                    smtp.Send(msg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.StackTrace);
                    throw;
                }

            } return View();
        }
    }
}