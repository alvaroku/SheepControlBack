using Business.Definitions;
using System.Net.Mail;
using System.Net;

namespace Business.Implementations
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmail(string emailTo, string body, string subject)
        {
            // Configuración del cliente SMTP para Gmail
            var smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential("soporte.usuarios123@gmail.com", "meycxkabipiqokgf")
            };

            // Crear el mensaje de correo electrónico
            var mailMessage = new MailMessage("soporte.usuarios123@gmail.com", emailTo, subject, body);
            mailMessage.IsBodyHtml = true;

            // Enviar el correo electrónico
            await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
