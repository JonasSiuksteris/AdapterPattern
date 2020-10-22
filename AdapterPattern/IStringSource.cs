using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IStringSource
    {
        public Task<string> GetString();
    }
}
