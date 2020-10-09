using System;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Program
    {
        private static async Task Main()
        {
            var test = new LatinApiStringSourceAdapter();

            Console.WriteLine(await test.GetString());

            var test2 = new FileStringSourceAdapter("Files/text.txt");

            Console.WriteLine(await test2.GetString());

        }
    }
}
