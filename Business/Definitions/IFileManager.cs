using Microsoft.AspNetCore.Http;

namespace Business.Definitions
{
    public interface IFileManager
    {
        string UploadImage(string pathFolderToUpload, IFormFile imageFile);
        void DeleteFile(string pathFolder,string fileName);
        bool ExistsFileInFolder(string pathFolder, string fileName);
        FileStream GetImage(string folerName, string fileName);
    }
}
