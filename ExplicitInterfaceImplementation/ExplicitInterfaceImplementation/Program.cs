using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    // Program to demo use of Explicit Interface implementation technique to implement void Method
    class Program
    {
        static void Main()
        {
        }
    }
    class B
    {
        public void Method()
        {
            Console.WriteLine("Void Method - B");
        }
    }
    interface I
    {
        void Method();
    }
    class D:B, I
    {
        void I.Method()
        {
            Console.WriteLine("Void Method - I");
        }
    }

}
