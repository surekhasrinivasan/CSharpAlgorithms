using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMultiplicationTable
{
    // Program to print multiplication table
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for which you want to print multiplication table: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your target? 10, 20, 30...");
            int target = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= target; i++)
            {
                int result = num * i;
                Console.WriteLine(num.ToString() + " X "+ i.ToString() + " = " + result.ToString());
            }
        }
    }
}
