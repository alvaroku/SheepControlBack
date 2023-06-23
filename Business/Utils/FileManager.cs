﻿using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp.Formats.Jpeg;
using System.Net.Mail;
using System.Net;
using OfficeOpenXml.Drawing;

namespace Business.Utils
{
    public class FileManager
    {
        public static string UploadImage(string fullPathImage, IFormFile imageFile)
        {
            var imageName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
            var pathComplete = Path.Combine(fullPathImage, imageName);

            using (var stream = new FileStream(pathComplete, FileMode.Create))
            {
                // Cargar la imagen utilizando la librería SixLabors.ImageSharp
                using (var image = Image.Load(imageFile.OpenReadStream()))
                {
                    // Calcular el nuevo tamaño de la imagen en función del porcentaje deseado
                    var width = (int)(image.Width * 0.3);
                    var height = (int)(image.Height * 0.3);

                    // Redimensionar la imagen al nuevo tamaño y guardarla en el stream
                    image.Mutate(x => x.Resize(new ResizeOptions
                    {
                        Size = new Size(width, height),
                        Mode = ResizeMode.Max
                    }));

                    // Guardar la imagen comprimida en formato JPEG con calidad 80%
                    image.Save(stream, new JpegEncoder
                    {
                        Quality = 80
                    });
                }
            }
            return imageName;
        }
        public static void DeleteFile(string _path)
        {
            if (File.Exists(_path))
            {
                File.Delete(_path);
            }
        }
    }
    public static class EmailSender
    {
        public static void SendEmail(string emailTo, string message,string subject)
        {
            // Configuración del cliente SMTP para Gmail
            var smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential("soporte.usuarios123@gmail.com", "meycxkabipiqokgf")
            };

            // Crear el mensaje de correo electrónico
            var mailMessage = new MailMessage("soporte.usuarios123@gmail.com", emailTo,subject , message);
            mailMessage.IsBodyHtml = true;

            // Enviar el correo electrónico
            smtpClient.Send(mailMessage);
        }
    }
}
