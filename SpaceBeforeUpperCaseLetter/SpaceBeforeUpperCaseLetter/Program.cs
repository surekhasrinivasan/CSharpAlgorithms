using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBeforeUpperCaseLetter
{
    // Program that inserts a single space before every upper case letter. For example, 
    // if we have string like "ProductUnitPrice", the program should convert it to "Product Unit Price".
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for the input string
            Console.WriteLine("Enter a string: ");

            // Read the input from the console
            string userInput = Console.ReadLine();

            // Convert the string to character array
            char[] arrUserInput = userInput.ToCharArray();
        }
    }
}
