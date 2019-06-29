using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEvenNumbers
{
    // Program to print even numbers
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a target number: ");
            int targetnumber = Convert.ToInt32(Console.ReadLine());

            // Two methods to print even numbers

            // 1. Use a FOR or WHILE loop to print the even numbers, until our target number
            for(int i = 0; i <= targetnumber; i = i + 2)
            {
                Console.WriteLine(i);
            }

            // 2. Check if a number is even by dividing it by 2
        }
    }
}
