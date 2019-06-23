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
            return new Person("Tina", i); // ("Tina" is Latin for "No one".)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Mike", 25);

            // convert a Person object to an int.
            int age = person1;
            Console.WriteLine("Person Info: {0}, {1}", person1.Name, age);
            // convert an int to a Person object
            Person person2 = 35;
            Console.WriteLine("Person Info: {0}, {1}", person2.Name, person2.Age);
        }
    }
}
