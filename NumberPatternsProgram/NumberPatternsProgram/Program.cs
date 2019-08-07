using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPatternsProgram
{
    // Program to demo different Number Patterns 
    class Program
    {
        //static void Main(string[] args)
        //{
        //    // Pyramid Number pattern
        //    int num, space;

        //    while (true)
        //    {
        //        Console.WriteLine("Enter a number between 1 and 9: ");

        //        num = Convert.ToInt32(Console.ReadLine());

        //        space = num - 1; 

        //        for(int i = 1; i <= num; i++)
        //        {
        //            for(space = 1; space <=(num-i); space++)
        //            {
        //                Console.Write(" ");
        //            }
        //            for(int j=1; j <= i; j++)
        //            {
        //                Console.Write(j);
        //            }
        //            for(int k = i - 1; k >= 1; k--)
        //            {
        //                Console.Write(k);
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //}

        //// Number pattern 2 
        //public static void Main()
        //{
        //    int num = 5;

        //    for(int i = 1; i <= num; i++)
        //    {
        //        for(int j = 1; j <= i; j++)
        //        {
        //            Console.Write(i);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadKey();
        //}

        //// Number pattern 3
        //public static void Main()
        //{
        //    Console.WriteLine("Enter a number: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine();

        //    for(int i = 1; i < num; i++)
        //    {
        //        for(int j = 1; j <= i; j++)
        //        {
        //            Console.Write(j.ToString());                    
        //        }
        //        Console.WriteLine();
        //    }
        //    for(int i = num; i >=0; i--)
        //    {
        //        for(int j = 1; j <= i; j++)
        //        {
        //            Console.Write(j.ToString());                    
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}

        // Number pattern 4
        public static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for(int i = n; i >=0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j.ToString());
                }
            }
            Console.WriteLine();
        }
    }
}
