using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConversion
{
    // Program to perform Currency Conversions
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter your choice : \n 1-Dollar to Rupee \n 2-Euro to Rupee \n 3- Ringgit to Rupee");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Double dollar, rupee, val;
                    Console.WriteLine("Enter the Dollar Amount: ");
                    dollar = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Dollar Value : ");
                    val = double.Parse(Console.ReadLine());
                    rupee = dollar * val;
                    Console.WriteLine("{0} Dollar equals {1} Rupees", dollar, rupee);
                    break;
            }
        }
    }
}
