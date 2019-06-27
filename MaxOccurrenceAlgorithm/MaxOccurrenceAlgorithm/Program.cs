using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOccurrenceAlgorithm
{
    // Program to find the most frequent element in an Array
    class Program
    {
        static void MaxOccurrence(int[] array, Hashtable hs)
        {

        }
        static void Main(string[] args)
        {
            int[] array = new int[20] { 3, 6, 8, 5, 3, 5, 7, 6, 4, 3, 2, 3, 5, 7, 6, 4, 3, 4, 5, 7 };
            Hashtable hs = new Hashtable();
            MaxOccurrence(array, hs);
        }
    }
}
