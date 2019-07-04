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

            // Initialize StringBuilder object for the output
            StringBuilder sbOutput = new StringBuilder();

            // loop through each character in the string array
            foreach(char character in arrUserInput)
            {
                if (char.IsUpper(character))
                {
                    sbOutput.Append(" ");
                }
                sbOutput.Append(character);
            }
            sbOutput.Remove(0, 1);

            Console.WriteLine(sbOutput.ToString());

            Console.ReadLine();


        }
    }
}
