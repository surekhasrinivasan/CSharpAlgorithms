using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPatternsProgram
{
    // Program to demo different Star Patterns 
    class Program
    {
        static void Main(string[] args)
        {
            // Pattern 1

            for(int row = 8; row >=1; --row)
            {
                for(int col=1;col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Pattern 2
            for(int row=1; row <=8; ++row)
            {
                for(int col=1; col <=row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Pattern 3

            int val = 8;
            int i, j, k;
            for(i = 1; i <=val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    Console.Write(" ");
                }
                for(k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
