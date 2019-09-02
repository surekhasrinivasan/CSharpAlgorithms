using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionExample
{
    //// Program to demo Lambda Expression
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DoWork(6);
    //        Console.ReadLine();
    //    }

    //    public static void DoWork(int intnumber1)
    //    {
    //        int intnumber2 = 2;

    //        Action<int> action = (num) =>
    //        {
    //            for (int i = num; i < num + (intnumber1 * intnumber2); i++)
    //            {
    //                int result = i * 3 - 1;
    //                Console.WriteLine(string.Format("{0}, {1}", i, result));

    //            }
    //        };
    //        action(9);
    //    }
    //}

    // Program to modify local variables using Lambda Expression
    class Program
    {
        static void Main(string[] args)
        {
            int localVariable = 100;

            Action<int> addmethod = i => localVariable += i;



        }
    }
}
