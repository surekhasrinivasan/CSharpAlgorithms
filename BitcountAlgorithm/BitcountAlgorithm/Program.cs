using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcountAlgorithm
{
    // Program to demo Sparsh bitcount algorithm

    // Bitcount is useful when using compact data structures in memory with bits. Sparsh bitcount is a simple and 
    // fast algorithm that walks through all the bits that are set to one. It is static. It does not rely on saving state. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SparseBitcount(0));
            Console.WriteLine(SparseBitcount(1));
            Console.WriteLine(SparseBitcount(int.MaxValue));
            Console.WriteLine(SparseBitcount(256));
        }
        static int SparseBitcount(int n)
        {
            int count = 0;
            while(n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }
    }
}
