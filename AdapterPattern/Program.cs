using System;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main()
        {
            var consoleWriter = new ConsoleWriter();

            var test = new LatinApiStringSourceAdapter(new LatinApi());

            consoleWriter.Write(test);

            var test2 = new FileStringSourceAdapter(new ReadFromFile(),"Files/text.txt");

            consoleWriter.Write(test2);

        }
    }
}
