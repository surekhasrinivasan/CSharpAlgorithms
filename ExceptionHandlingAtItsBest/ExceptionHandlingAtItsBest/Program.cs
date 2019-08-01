using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAtItsBest
{
// Write a c# program to add two numbers. This may sound very simple, but the catch, is - The program should not break, and always should give meaningful error messages when exception conditions occur. For example, the following error conditions should be handled in your program. Also, the program should run as long as the user wants it to run.
// 1. If the user enters "Ten" instead of 10, the program should let the user know only numbers can be added.
// 2. If the user, enters a very large number, the program should let the user know about the range allowed.
    class Program
    {
        static void Main()
        {
            string strUserChoice = string.Empty;

            do
            {
                try
                {
                    Console.WriteLine("Please enter first number:");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter first number:");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Total = FN + SN;

                    Console.WriteLine("Total = {0}", Total);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input. Only numbers please.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Only numbers between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
                }
                catch (Exception)
                {
                    Console.WriteLine("Unknown problem, please contact administrator");
                }

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No?");
                    strUserChoice = Console.ReadLine();
                }
                while (strUserChoice.ToUpper() != "YES" && strUserChoice.ToUpper() != "NO");
            }
            while (strUserChoice.ToUpper() != "NO");
        }
    }
}
