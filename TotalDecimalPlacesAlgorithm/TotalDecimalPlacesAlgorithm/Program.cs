using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalDecimalPlacesAlgorithm
{
    // Program to get the total number of decimal places. Example 
    // Input : 1, 1.0, 1.1, 1.12
    // Output : 0, 0, 1, 2
    class Program
    {
        public static void Main(string[] args)
        {
            // Create the decimal array for sample test data 
            decimal[] decimalNumbers = { 1, 1.0M, 1.1M, 1.12M, 1.123M, 1.1100M, 1.010M, 1.001100M };

            // Loop through each decimal number
            foreach(decimal decimalNumber in decimalNumbers)
            {
                // Print the original number and total decimal places
                Console.WriteLine("Original Decimal Number = {0}, Total Decimal Places={1}", decimalNumber, GetDecimalPartCount(decimalNumber));
            }
        }

        // Function that return the total decimal places
        private static int GetDecimalPartCount(decimal decimalNumber)
        {
            // Dividing decimal number with 1 gives the decimal part
            decimal decimalPlaces = decimalNumber % 1;
            if(decimalPlaces != 0)
            {
                // Get the index of dot from the decimal part
                int indexOfDot = decimalPlaces.ToString().IndexOf('.');

                // Use the 0.######## format string to rip off trailing zeros, and get the count 
                int numberOfDecimals = decimalPlaces.ToString("0.##########").Substring(indexOfDot).Length - 1;

                return numberOfDecimals;
            }
            // Finally convert decimal to int and return
            return (int)decimalPlaces;
        }
    }
}
