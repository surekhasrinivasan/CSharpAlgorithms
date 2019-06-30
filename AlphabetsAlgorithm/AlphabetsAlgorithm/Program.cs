using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetsAlgorithm
{
    // Program prints both upper and lower case alphabets
    class Program
    {
        static void Main(string[] args)
        {
            // Loop from 'a' through 'z' (lower case alphabets)
            for(char alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                Console.WriteLine(alphabet);
            }
        }
    }
}
