using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    // Program that builds a simple calculator which has following features:
    // Adding 2 Numbers
    // Subtracting 2 Numbers
    // Multiplying 2 Numbers
    // Dividing 2 Numbers

    class Program
    {
        static void Main(string[] args)
        {

        }
        public void PrintMenu()
        {

        }

        public static void Calculate(int SelectedOption)
        {
            int Result = 0;
            Console.WriteLine("Enter your first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (SelectedOption)
            {
                case 1:
                    Result = firstNumber + secondNumber;
                    Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, Result);
                    break;
                case 2:
                    Result = firstNumber - secondNumber;
                    Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, Result);
                    break;
                case 3:
                    Result = firstNumber * secondNumber;
                    Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, Result);
                    break;
                case 4:
                    Result = firstNumber / secondNumber;
                    Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, Result);
                    break;
            }
        }
    }
}
