using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IStringSourceAdapter
    {
        public Task<string> GetString();
    }
}
