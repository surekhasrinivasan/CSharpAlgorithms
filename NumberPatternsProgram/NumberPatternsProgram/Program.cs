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

        //// Number pattern 4
        //public static void Main()
        //{
        //    Console.WriteLine("Enter a number: ");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine();
        //    for(int i = n; i >=0; i--)
        //    {
        //        for(int j = 1; j <= i; j++)
        //        {
        //            Console.Write(j.ToString());
        //        }
        //        Console.WriteLine();
        //    }            
        //    for(int i = 1; i <= n; i++)
        //    {
        //        for(int j = 1; j <= i; j++)
        //        {
        //            Console.Write(j.ToString());
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}

        //// Number Pattern 5
        //public static void Main()
        //{
        //    int i, j, n, p, q;

        //    Console.Write("\n\n");
        //    Console.Write("Print the Floyd's Triangle: \n");
        //    Console.Write("------------------------------");
        //    Console.Write("\n\n");

        //    Console.Write("Input number: ");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    for(i = 1; i <= n; i++)
        //    {
        //        if (i % 2 == 0)
        //        { 
        //            p = 1; q = 0;
        //        }
        //        else
        //        {
        //            p = 0; q = 1;
        //        }
        //        for (j = 1; j <= i; j++)
        //            if (j % 2 == 0)
        //                Console.Write("{0}", p);
        //            else
        //                Console.Write("{0}", q);
        //        Console.Write("\n");
        //    }
        //}

        //// Number Pattern 6
        //public static void Main()
        //{
        //    int i, j, rows, k = 1;

        //    Console.Write("\n\n");
        //    Console.Write("Display the pattern like right angle triangle with number increased by 1: \n");
        //    Console.Write("----------------------------------------------------------------------------");
        //    Console.Write("\n\n");

        //    Console.Write("Input number of rows : ");
        //    rows = Convert.ToInt32(Console.ReadLine());
        //    for(i = 1; i <= rows; i++)
        //    {
        //        for(j = 1; j <= i; j++)
        //            Console.Write("{0} ", k++);
        //        Console.Write("\n");
        //    }
        //}

        //// Number Pattern 7 
        //public static void Main()
        //{
        //    for(int i = 1; i <= 5; i++)
        //    {
        //        for(int j =1; j <= i; j++)
        //        {
        //            Console.Write("" + (j));
        //        }
        //        Console.WriteLine();
        //    }
        //    for(int k = 4; k >=0; --k)
        //    {
        //        for(int j = 1; j <= k; j++)
        //        {
        //            Console.Write("" + (k));
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //// Number pattern 8
        //public static void Main()
        //{
        //    int row, i, j, k;
        //    Console.Write("Enter the no. of row you want to print: ");
        //    row = Convert.ToInt32(Console.ReadLine());

        //    for(i = 0; i  <= row; i++)
        //    {
        //        k = 1;
        //        for (j = i; j <= row - 1; j++)
        //            Console.Write(" ");
                
        //        for (j = 0; j <= i; j++)
        //        {
        //            Console.Write("{0} ", k);
        //            k = (k * (i - j) / (j + 1));
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadLine();
        //}

        // Number pattern 9
        public static void Main()
        {

        }
    }
}

