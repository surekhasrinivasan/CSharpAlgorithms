using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintUniqueNames
{
    // Program to print unique names, by removing duplicate entries. 
    // example: Input - "Rob;Mike;Able;Sara;Rob;Peter;Able;"
    //          Output - "Rob;Mike;Able;Sara;Peter;"
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the list of user names
            Console.WriteLine("Enter a list of names separated by semicolon: ");

            // Read the user name list from the console
            string strUserNames = Console.ReadLine();

            // split the string into a string array based on semi colon
            string[] arrUserNames = strUserNames.Split(';');

            // Use the Distinct() LINQ function to remove duplicates
            string[] arrUniqueNames = arrUserNames.Distinct().ToArray();

            // Using StringBuilder to concatenate strings is more efficient
            // than using immutable string objects for better performance
            StringBuilder sbUniqueUserNames = new StringBuilder();

            // Build the string from unique names appending semicolon
            foreach(string strName in arrUniqueNames)
            {
                sbUniqueUserNames.Append(strName + ";");
            }

            // Remove the extra semi colon in the end
            sbUniqueUserNames.Remove(sbUniqueUserNames.ToString().LastIndexOf(';'),1);

            // Finally print the unique names
            Console.WriteLine();
            Console.WriteLine("Printing names without duplicates");
            Console.WriteLine(sbUniqueUserNames.ToString());
            Console.WriteLine();
        }
    }
}
