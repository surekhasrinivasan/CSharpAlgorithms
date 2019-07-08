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
        }
    }
}
