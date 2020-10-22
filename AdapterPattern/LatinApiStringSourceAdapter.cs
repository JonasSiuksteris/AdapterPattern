using System.Net.Http;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class LatinApi
    {
        private const string Url = "https://latinwordnet.exeter.ac.uk/api/index/v/";

        public async Task<string> GetText()
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(Url);
        }
    }

    public class LatinApiStringSourceAdapter : IStringSource
    {
        private readonly LatinApi _latinApi;

        public LatinApiStringSourceAdapter(LatinApi latinApi)
        {
            _latinApi = latinApi;
        }

        public async Task<string> GetString()
        { 
            return await _latinApi.GetText();
        }
    }
}

