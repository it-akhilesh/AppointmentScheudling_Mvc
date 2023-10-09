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
                
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
            .Property(Send.FromEmail, "ben.spark90@gmail.com")
            .Property(Send.FromName, "Appointment Scheduler")
            .Property(Send.Subject, subject)
            
            .Property(Send.HtmlPart, htmlMessage)
            .Property(Send.Recipients, new JArray
            {
                new JObject
                {
                    {"Email", email }
                }
            });
            MailjetResponse response = await client.PostAsync(request);
        }
    }
}
