using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestAndLargestNum
{
    // Program to find and print, the smallest and largest number in the integer array
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the integer array
            int[] NumbersArray = { 102, 34, 89, 12, 187, 29, 111 };

            // Sort the array, first element in the array will be 
            // smallest and the last element will be largest
            Array.Sort(NumbersArray);

            // Print the smallest number in the array
            Console.WriteLine("Smallest Number = {0}", NumbersArray[0]);

            // Print the largest number in the array
            Console.WriteLine("Largest Number = {0}", NumbersArray[NumbersArray.Length-1]);

            Console.ReadLine();
        }
    }
}
