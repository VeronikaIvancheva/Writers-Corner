using System.IO;

namespace WritersCorner.Service.Providers
{
    public class FileService : IFileService
    {
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath.Trim());
        }

        public (bool result, string message) CreateFolder(string filePath)
        {
            if (FileExists(filePath.Trim()))
            {
                return (true, $"Folder already exists: {filePath}");
            }

            try
            {
                Directory.CreateDirectory(filePath);
                return (true, "");
            }
            catch (IOException e)
            {
                return (false, e.Message);
            }
        }
    }
}
