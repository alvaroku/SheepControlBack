using System.Net;
using System.Net.Mail;

namespace Business.Utils
{
    public static class EmailSender
    {
        public static void SendEmail(string emailTo, string body, string subject)
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
            smtpClient.Send(mailMessage);
        }
        public static void SendEmailDataAccess(string name, string email, string password, string mensaje, string asunto)
        {
            string body = Constants.plantillaEmailDataAccess;
            body = body.Replace("{name}", name);
            body = body.Replace("{email}", email);
            body = body.Replace("{password}", password);
            body = body.Replace("{message}", mensaje);
            SendEmail(email, body, asunto);
        }
        public static void SendEmailResetPassword(string name, string email, string password)
        {
            string body = Constants.plantillaEmailRecoveryPassword;
            body = body.Replace("{name}", name);
            body = body.Replace("{password}", password);
            SendEmail(email, body, "Recuperación de contraseña");
        }//Te proporcionamos tus datos de acceso para que puedas ingresar al sistema
        //"Cambios datos de acceso Sheep Control"
        //
    }

}
