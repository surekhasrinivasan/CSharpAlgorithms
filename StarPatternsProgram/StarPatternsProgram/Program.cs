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
        //static void Main(string[] args)
        //{
            //// Pattern 1

            //for(int row = 8; row >=1; --row)
            //{
            //    for(int col=1;col <= row; ++col)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Pattern 2
            //for(int row=1; row <=8; ++row)
            //{
            //    for(int col=1; col <=row; ++col)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Pattern 3

            //int val = 8;
            //int i, j, k;
            //for(i = 1; i <=val; i++)
            //{
            //    for (j = 1; j <= val - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Pattern 4

            //int num = 8;

            //for(i = 0; i < num; ++i)
            //{
            //    for(j = 0; j<=i; ++j)
            //    {
            //        Console.Write("*");
            //    }
            //    if(i != num - 1)
            //    {
            //        Console.Write(" ");
            //    }
            //    else
            //    {
            //        Console.Write(" * ");
            //    }
            //    for(j=0; j <= i; ++j)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Pattern 5
            //int number = 7;

            //for(i = 0; i < number; i++)
            //{
            //    if(i == 0 || i == 6)
            //    {
            //        for(j=0; j < number; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //    if(i>=1 && i <= 5)
            //    {
            //        for(j=0; j< number; j++)
            //        {
            //            if(j == 0 || j == 6)
            //            {
            //                Console.Write("*");
            //            }
            //            else if(j >= 1 && j <= 5)
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //// Pattern 6

            //int numb, i, k, count = 1;
            //Console.WriteLine("Enter the number of rows: ");
            //numb = int.Parse(Console.ReadLine());

            //count = numb - 1;
            //for (k = 1; k <= numb; k++)
            //{
            //    for (i = 1; i <= count; i++)
            //        Console.Write(" ");
            //    count--;
            //    for (i = 1; i <= 2 * k - 1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //count = 1;
            //for (k = 1; k <= numb - 1; k++)
            //{
            //    for(i=1; i<=count; i++)
            //        Console.Write(" ");
            //    count++;
            //    for(i=1;i<=2 * (numb - k) -1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            // Pattern 7

           static void stars(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write("*");
        } 

        static void spaces(int count)
        {
            for (int i = 0; i < count; ++i)
                Console.Write(" ");            
        }
        public static void Main()
        {
            int n = 8;

            for(int i = 0; i < n; ++i)
            {
                stars(i + 1);
                spaces(n - i - 1);
                stars(n - i + 1);
                spaces(2 * i);
                stars(n - i);
                spaces(n - i - 1);
                stars(i + 1);

                Console.WriteLine();
            }
        }
    }
}
