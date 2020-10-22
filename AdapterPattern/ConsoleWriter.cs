using System;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ConsoleWriter
    {
        public void Write(IStringSource stringSource)
        {
            Console.WriteLine(stringSource.GetString().Result);
        }
    }
}
