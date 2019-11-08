using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program to demo Delegate Example in CSharp

delegate int NumberChanger(int n);

namespace DelegateInCSharpExample
{
    class Program
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        static void Main(string[] args)
        {
        }
    }
}
