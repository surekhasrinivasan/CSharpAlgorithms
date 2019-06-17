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
                case 2:
                    Double euro, rupe, valu;
                    Console.WriteLine("Enter the Euro Amount : ");
                    euro = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Euro value : ");
                    valu = double.Parse(Console.ReadLine());
                    rupe = euro * valu;
                    Console.WriteLine("{0} Euro equals {1} Rupees", euro, rupe);
                    break;
                case 3:
                    Double ringgit, rup, value;
                    Console.WriteLine("Enter the Ringgit Amount : ");
                    ringgit = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Ringgit Value: ");
                    value = double.Parse(Console.ReadLine());
                    rup = ringgit * value;
                    Console.WriteLine("{0} Ringgit equals {1} Rupees", ringgit, rup);
                    break;
            }
            Console.ReadLine();
        }
    }
}
