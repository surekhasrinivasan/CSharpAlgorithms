using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistanceAlgorithm
{
    // The Hamming Distance measures the minimum number of substitutions required to change one string into the other.
    // The Hamming distance between two strings of equal length is the number of positions at which the corresponding 
    // symbols are different.

    // In below example, we will take two strings and if length of strings are not equal then we will show exception 
    // else it will calculate the distance between two strings.
    class Program
    {        
        static void Main()
        {
            Console.WriteLine(StringDistance.GetHammingDistance("climax", "volmax"));
            Console.WriteLine(StringDistance.GetHammingDistance("Ram", "Rom"));
            Console.WriteLine(StringDistance.GetHammingDistance("Mam", "Mom"));
        }
    }

    public static class StringDistance
    {
        public static int GetHammingDistance(string s, string t)
        {
            if (s.Length != t.Length)
            {
                throw new Exception("Strings must be equal length");
            }

            int distance =
                s.ToCharArray()
                .Zip(t.ToCharArray(), (c1, c2) => new { c1, c2 })
                .Count(m => m.c1 != m.c2);

            return distance;
        }
    }    
}
