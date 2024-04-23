using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Falzoni.Utils.Keys;

namespace Falzoni.Service.Senders.Email
{
    public class EmailIdentityMessageService : IIdentityMessageService
    {
        public async Task SendAsync(IdentityMessage message)
        {
            SmtpClient client = new SmtpClient(EmailKeys.EmailHost, EmailKeys.EmailPort)
            {
                Credentials = new NetworkCredential(EmailKeys.EmailUserName, EmailKeys.EmailPassword),
                EnableSsl = true
            };

            MailAddress from = new MailAddress(EmailKeys.EmailFromAddress, EmailKeys.EmailFromDescription);
            MailAddress to = new MailAddress(message.Destination, message.Destination);

            var mailMessage = new MailMessage(from, to);
            mailMessage.Subject = message.Subject;
            mailMessage.Body = message.Body;

            await client.SendMailAsync(mailMessage);
        }
    }
}
