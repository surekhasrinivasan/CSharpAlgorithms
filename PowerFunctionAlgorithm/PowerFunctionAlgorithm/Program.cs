using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerFunctionAlgorithm
{
    // Program that demo power function()

    // The function takes 2 parameters - Base and Exponent. The function returns back the result of "Base raised to the power of exponent". 
    // For example - When the Power() method is called using parameters 3 and 4.The value of 3 to the power of 4 should be returned back, i.e 81.
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter base
            Console.WriteLine("Enter your base number: ");
            int Base = Convert.ToInt32(Console.ReadLine());

            // Prompt the user to enter exponent
            int Exponent = Convert.ToInt32(Console.ReadLine());

            // call the power method passing its Base and Exponent
            //int Result = Power(Base, Exponent);

            // In System.Math class there is Pow() static method which is 
            // very similar to the static Power() method we implemented

            double Result = System.Math.Pow(Base, Exponent);

            // print the result 
            Console.WriteLine("Result={0}", Result);
        }

        // Power Function
        public static int Power(int Base, int Exponent)
        {
            // Declare a variable to hold the result 
            int Result = 1;

            // multiply base number with itself, for
            // exponentnumber of times
            for(int i = 1; i <= Exponent; i++)
            {
                Result = Result * Base;
            }
            // return the Result
            return Result;
        }
    }
}
