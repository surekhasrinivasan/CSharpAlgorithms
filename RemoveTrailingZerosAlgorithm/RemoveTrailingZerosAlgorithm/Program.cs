using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTrailingZerosAlgorithm
{
    // Program to remove trailing zeros in a decimal
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] decimalNumbers = { 1.0M, 1.01M, 1.0010M, 0.00M, 1.0050M};

            foreach(decimal decimalNumber in decimalNumbers)
            {
                Console.WriteLine("Original Decimal Number = {0}, Without Zeros = {1}",
                                    decimalNumber, decimalNumber.ToString("0.####"));
            }
            Console.ReadLine();
        }
    }
}
