using Microsoft.AspNetCore.Http;
namespace Core.Utilities.UploadFile

{
    public interface IFileService
    {
        string Upload(IFormFile file, string root);
        void Delete(string filePath);
        string Update(IFormFile file, string filePath, string root);
    }
}
