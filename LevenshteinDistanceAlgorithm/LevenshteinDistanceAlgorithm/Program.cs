﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevenshteinDistanceAlgorithm
{
    // Program to demo Levenshtein Distance Algorithm

    // The Levenshtein distance is a string metric for measuring the difference between two sequences. 
    // The Levenshtein distance between two words is the minimum number of single-character edits 
    // (i.e. insertions, deletions or substitutions) required to change one word into the other.

    public static class StringDistance
    {
        // Compute the distance between two strings 
        public static int LevenshteinDistance(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            if (n == 0)
                return m;
            if (m == 0)
                return n;
            for(int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for(int j = 0; j <=m; d[0,j] = j++)
            {
            }

            for(int i =1; i <= n; i++)
            {
                for(int j = 1; j <= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            return d[n, m];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringDistance.LevenshteinDistance("climax", "volmax"));
            Console.WriteLine(StringDistance.LevenshteinDistance("Ram", "Raman"));
            Console.WriteLine(StringDistance.LevenshteinDistance("Mama", "Mom"));
        }
    }
}
