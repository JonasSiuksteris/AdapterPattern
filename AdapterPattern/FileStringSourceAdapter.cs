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

    public class FileStringSourceAdapter : IStringSourceAdapter
    {
        private readonly ReadFromFile _readFromFile = new ReadFromFile();
        private readonly string _fileName;

        public FileStringSourceAdapter(
            string fileName)
        {
            _fileName = fileName;
        }
        public async Task<string> GetString()
        {
            return await _readFromFile.GetFileText(_fileName);
        }
    }
}
