using Business.Definitions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
namespace Business.Implementations
{
    /// <summary>
    /// Para usar este servicio se debe tener ya la estructura base de las carpetas necesarias
    ///     wwwroot
    ///         imgs
    ///             sheep
    ///             vaccine
    ///             user
    /// </summary>
    public class LocalFileManager : IFileManager
    {
        string basePath = string.Empty;
        public LocalFileManager(IHostingEnvironment hostingEnvironment) {
            basePath = Path.Combine(hostingEnvironment.ContentRootPath, "wwwroot");
        }
        public void DeleteFile(string pathFolder, string fileName)
        {
            if (ExistsFileInFolder(pathFolder,fileName))
            {
                File.Delete(Path.Combine(basePath,pathFolder, fileName));
            }
        }

        public bool ExistsFileInFolder(string pathFolder, string fileName)
        {
            return File.Exists(Path.Combine(basePath,pathFolder, fileName));
        }

        public string UploadImage(string pathFolderToUpload, IFormFile imageFile)
        {
            var imageName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
            var pathComplete = Path.Combine(basePath, pathFolderToUpload, imageName);

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
        public FileStream GetImage(string folerName,string fileName)
        {
            string filePath = Path.Combine(basePath, folerName, fileName);
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
           return fileStream;
        }
    }
}
