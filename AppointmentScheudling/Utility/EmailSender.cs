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
                            {"Email", email},
                            
                        }
                    } },
                    {"Subject", subject},
                    
                    {"HTMLPart", htmlMessage}
                    }
            });
            
                          
            MailjetResponse response = await client.PostAsync(request);
        }
    }
}
