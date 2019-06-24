using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackAlgorithm
{
    // Program to implement knapsack algorithm
    class Program
    {
        public static int KnapSack(int capacity, int[] weight, int[] value, int itemsCount)
        {
            int[,] k = new int[itemsCount + 1, capacity + 1];

            for(int i=0; i <= itemsCount; ++i)
            {
                for(int w =0; w <= capacity; ++w)
                {
                    if (i == 0 || w == 0)
                        k[i, w] = 0;
                    else if (weight[i - 1] <= w)
                        k[i, w] = Math.Max(value[i - 1] + k[i - 1, w - weight[i - 1]], k[i - 1, w]);
                    else
                        k[i, w] = k[i - 1, w];                
                }
            }
            return k[itemsCount, capacity];
        }

        // main method
        static void Main(string[] args)
        {
        }
    }
}
