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
            // To call class B Method
            D d = new D();
            d.Method();

            // To call the Interface Method
            I i = new D();
            i.Method();

            // Another way to call interface method
            ((I)d).Method();
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
