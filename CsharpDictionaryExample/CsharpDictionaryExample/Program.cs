using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDictionaryExample
{
    // Program to demo example of csharp Dictionary
    class Program
    {
        static void Main(string[] args)
        {
            var Books = new Dictionary<int, string>()
            {
                [1] = "ASP.Net",
                [2] = "C#",
                [3] = "ASP.Net MVC5"
            };

        }
    }
}
