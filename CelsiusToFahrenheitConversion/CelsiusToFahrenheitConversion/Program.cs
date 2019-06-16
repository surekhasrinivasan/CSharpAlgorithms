using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheitConversion
{
    // Program to Perform Celsius to Fahrenheit Conversion
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, faren;
            Console.WriteLine("Enter the Temperature in Celsius: ");
            celsius = int.Parse(Console.ReadLine());
            // Calculate temperature in fahrenheit from celsius
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit: {0}", faren);
            Console.ReadLine();
        }
    }
}
