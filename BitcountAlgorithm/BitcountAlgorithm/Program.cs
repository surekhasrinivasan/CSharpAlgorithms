﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitcountAlgorithm
{
    // Program to demo Sparsh bitcount algorithm

    // Bitcount is useful when using compact data structures in memory with bits. Sparsh bitcount is a simple and 
    // fast algorithm that walks through all the bits that are set to one. It is static. It does not rely on saving state. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SparseBitcount(0));
            Console.WriteLine(SparseBitcount(1));
            Console.WriteLine(SparseBitcount(int.MaxValue));
            Console.WriteLine(SparseBitcount(256));

            Console.WriteLine(IteratedBitcount(0));
            Console.WriteLine(IteratedBitcount(1));
            Console.WriteLine(IteratedBitcount(int.MaxValue));
            Console.WriteLine(IteratedBitcount(256));

            // Initialize the lookup table
            InitializeBitcounts();

            // Get the bitcounts for these values by lookups
            Console.WriteLine(PrecomputedBitcount(0));
            Console.WriteLine(PrecomputedBitcount(1));
            Console.WriteLine(PrecomputedBitcount(int.MaxValue));
            Console.WriteLine(PrecomputedBitcount(256));
        }

        static int SparseBitcount(int n)
        {
            int count = 0;
            while(n != 0)
            {
                count++;
                n &= (n - 1);
            }
            return count;
        }

        // Iterated Bitcount algorithm

        // This bitcount is slow, simple and reliable

        static int IteratedBitcount(int n)
        {
            int test = n;
            int count = 0;

            while(test != 0)
            {
                if((test & 1) == 1)
                {
                    count++;
                }
                test >>= 1;
            }
            return count;
        }

        // Precomputed bitcount algorithm

        // This program demonstrates the use of a precomputed bitcount lookup table. 
        // The InitializeBitcounts method uses a logical method to precompute the bits
        // in the table based on how the binary representation changes.

        static int[] _bitcounts; // Lookup table

        static void InitializeBitcounts()
        {
            _bitcounts = new int[65536];
            int position1 = -1;
            int position2 = -1;

            // Loop through all the elements and assign them. 
            for(int i=1; i< 65536; i++, position1++)
            {
                // Adjust the positions we read from.
                if(position1 == position2)
                {
                    position1 = 0;
                    position2 = i;
                }
                _bitcounts[i] = _bitcounts[position1] + 1;
            }
        }

        static int PrecomputedBitcount(int value)
        {
            // Count bits in each half of the 32-bit input number.
            return _bitcounts[value & 65535] + _bitcounts[(value >> 16) & 65535];
        }

    }
}
