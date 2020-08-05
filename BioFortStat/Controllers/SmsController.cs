using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML.Messaging;
using Twilio.TwiML;
using Twilio.AspNet.Mvc;
using Twilio.Clients;

namespace BioFortStat.Controllers
{
    public class SmsController : TwilioController
    {
        // GET: Sms
        public ActionResult ReceiveSms(string From, string Body)
        {
            var response = new MessagingResponse();
            var message = new Message();
            message.Body($"Harvest{From}. Plus{Body}");
            response.Append(message);
            // response.Redirect(url: new Uri(""));
            return TwiML(response);
        }

        // https://www.c-sharpcorner.com/article/sending-sms-using-asp-net-core-with-twilio-sms-api/
        public ActionResult SendSms()
        {
            var accountSid = "AC74576c34d209ad8160ecee0ed314c1b3";
            var authToken = "ecff72b6f139239c1723b93149e47a8a";

           var client = new TwilioRestClient(accountSid, authToken);

            try
            {
                var message = MessageResource.Create(
          body: "Harvest Plus needs your crops information.",
          from: new Twilio.Types.PhoneNumber("+19565679341"),
          to: new Twilio.Types.PhoneNumber("+2348031143356"),
          client : client
          );

                return Content(message.Sid);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.StackTrace);
                throw;
            }

           
        }
    }
}