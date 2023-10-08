using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;


namespace AppointmentScheudling.Utility
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailjetClient client = new MailjetClient(Environment.GetEnvironmentVariable("MJ_APIKEY_PUBLIC"), Environment.GetEnvironmentVariable("MJ_APIKEY_PRIVATE"))
            {
                Version = ApiVersion.V3_1,
            };

            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }

            .Property(Send.Messages, new JArray
            {
                new JObject
                {
                    {"From", new JObject
                    {
                        {"Email", "pilot@mailjet.com"},
                        {"Name", "Mailjet Pilot"}
                    } },
                    {"To", new JArray
                    {
                        new JObject
                        {
                            {"Email", "passenger1@mailjet.com"},
                            {"Name","passenger 1"}
                        }
                    } },
                    {"Subject", "Your email flight plan!"},
                    {"TextPart", "Dear passenger 1, welcome to Mailjet! May the delivery force be with you!" },
                    {"HTMLPart", "<h3>Dear passenger 1, welcome to " +
                    "<a href=\"https://www.mailjet.com/\">Mailjet</a>!</h3><br />May the delivery force be with you!"}
                    }
            });
            
                          
            MailjetResponse response = await client.PostAsync(request);
        }
    }
}
