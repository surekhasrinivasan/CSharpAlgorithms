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
        public static int GetHammingDistance(string s, string t)
        {
            if(s.Length != t.Length)
            {
                throw new Exception("Strings must be equal length");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
