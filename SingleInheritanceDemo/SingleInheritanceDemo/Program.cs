using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritanceDemo
{
    // Program to illustrate Single Inheritance. Single Inheritance means single base class and 
    // that is derived by multiple derived class.
    class Program
    {
        static void Main(string[] args)
        {
            Coach c = new Coach();
            c.coach();
            Player p = new Player();
            p.Play();
            p.coach();
            Console.ReadKey();
        }

        class Coach
        {
            public void coach()
            {
                Console.WriteLine("Coach");
            }
        }

        class Player : Coach
        {
            public void Play()
            {
                Console.WriteLine("Play");
            }
        }
    }
}
