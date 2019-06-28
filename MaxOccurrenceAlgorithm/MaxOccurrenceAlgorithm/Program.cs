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
            int mostCommon = array[0];
            int occurences = 0;

            foreach(int num in array)
            {
                if (!hs.ContainsKey(num))
                {
                    hs.Add(num, 1);
                }
                else
                {
                    int tempOccurence = (int)hs[num];
                    tempOccurence++;
                    hs.Remove(num);
                    hs.Add(num, tempOccurence);

                    if(occurences < tempOccurence)
                    {
                        occurences = tempOccurence;
                        mostCommon = num;
                    }
                }
            }
            foreach(DictionaryEntry entry in hs)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("The common number is: " + mostCommon + "And it appears " + occurences + " times");
        }

        static void Main(string[] args)
        {
            int[] array = new int[20] { 3, 6, 8, 5, 3, 5, 7, 6, 4, 3, 2, 3, 5, 7, 6, 4, 3, 4, 5, 7 };
            Hashtable hs = new Hashtable();
            MaxOccurrence(array, hs);
        }
    }
}
