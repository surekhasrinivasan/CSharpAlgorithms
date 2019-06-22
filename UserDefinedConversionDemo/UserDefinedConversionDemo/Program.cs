using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedConversionDemo
{
    // Program to demo User Defined Conversion

    class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public static implicit operator int(Person p) // Convert Person to int
        {
            return p.Age;
        }
        public static implicit operator Person(int i) // Convert int to Person.
        {
            return new Person("Tina", i) // ("Tina" is Latin for "No one".)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
