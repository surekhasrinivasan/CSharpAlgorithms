using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToMultipleBases
{
    // Program to convert Decimal to Multiple base using Stack
    class Program
    {
        static void Main(string[] args)
        {
            int num, baseNum;

            Console.WriteLine("Enter a decimal number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a base: ");
            baseNum = Convert.ToInt32(Console.ReadLine());
        }
    }
}
