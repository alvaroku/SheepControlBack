using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Processing;
using System.IO;

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
}
