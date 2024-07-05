using Business.Definitions;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace Business.Implementations
{
    public class EmailSender : IEmailSender
    {
        IConfiguration _configuration;
        public EmailSender(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public async Task SendEmail(string emailTo, string body, string subject)
        {
            // Configuración del cliente SMTP para Gmail
            var smtpClient = new SmtpClient(_configuration["email:smtp"], int.Parse(_configuration["email:port"]))
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential(_configuration["email:from"], _configuration["email:pwd"])
            };

            // Crear el mensaje de correo electrónico
            var mailMessage = new MailMessage(_configuration["email:from"], emailTo, subject, body);
            mailMessage.IsBodyHtml = true;

            // Enviar el correo electrónico
            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
