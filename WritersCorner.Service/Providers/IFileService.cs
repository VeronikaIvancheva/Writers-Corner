
namespace WritersCorner.Service.Providers
{
    public interface IFileService
    {
            bool FileExists(string filePath);
            (bool result, string message) CreateFolder(string filePath);
    }
}
