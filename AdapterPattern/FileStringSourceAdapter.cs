using System.IO;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ReadFromFile
    {
        public async Task<string> GetFileText(string fileName)
        {
            return await File.ReadAllTextAsync(fileName);
        }
    }

    public class FileStringSourceAdapter : IStringSource
    {
        private readonly ReadFromFile _readFromFile;
        private readonly string _fileName;

        public FileStringSourceAdapter(ReadFromFile readFromFile,
            string fileName)
        {
            _readFromFile = readFromFile;
            _fileName = fileName;
        }
        public async Task<string> GetString()
        {
            return await _readFromFile.GetFileText(_fileName);
        }
    }
}
