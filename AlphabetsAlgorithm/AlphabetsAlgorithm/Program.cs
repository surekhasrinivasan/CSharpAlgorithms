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
            for (char alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                Console.Write(alphabet + " ");
            }

            Console.WriteLine();

            // Another way to print lower case alphabets
            for (int i = 0; i < 26; i++)
            {
                Console.Write(Convert.ToChar(i + (int)'a') + " ");
            }

            Console.WriteLine();

            // Loop from 'A' through 'Z' (upper case alphabets)
            for(char alphabet = 'A'; alphabet <= 'Z'; alphabet++)
            {
                Console.Write(alphabet + " ");
            }
            Console.ReadLine();
        }
    }
}
