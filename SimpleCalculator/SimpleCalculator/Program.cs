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
        public static void Main()
        {
            string UserSelection = string.Empty;

            do
            {
                PrintMenu();
                int UserChoice = Convert.ToInt32(Console.ReadLine());
                while (UserChoice < 1 || UserChoice > 4)
                {
                    Console.WriteLine("Invalid Option. Try again");
                    PrintMenu();
                    Console.WriteLine();
                    UserChoice = Convert.ToInt32(Console.ReadLine());
                }
                Calculate(UserChoice);

                Console.WriteLine("Do you want to continue ?");
                UserSelection = Console.ReadLine();
                while (UserSelection.ToUpper() != "NO" && UserSelection.ToUpper() != "YES")
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input - Please type YES or NO");
                    Console.WriteLine("Do you want to continue ?");
                    UserSelection = Console.ReadLine();
                }
            }
            while (UserSelection.ToUpper() != "NO");
            Console.WriteLine();
            Console.WriteLine("The program will now terminate. GoodBye!");            
        }

        public static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select your option");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine();
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
