using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamerauLevenshteinDistanceAlgorithm
{
    // Program to demo Damerau Levenshtein Distance Algorithm

    // The Damerau–Levenshtein distance differs from the classical Levenshtein distance by including transpositions among its allowable operations. 
    // The classical Levenshtein distance only allows insertion, deletion, and substitution operations.Modifying this distance by including 
    // transpositions of adjacent symbols produces a different distance measure, known as the Damerau–Levenshtein distance.

    public static class StringDistance
    {
        public static int GetDamerauLevenshteinDistance(string s, string t)
        { 
            var bounds = new { Height = s.Length + 1, Width = t.Length + 1 };

            int[,] matrix = new int[bounds.Height, bounds.Width];

            for(int height = 0; height < bounds.Height; height++) { matrix[height, 0] = height; };
            for(int width = 0; width < bounds.Width; width++) { matrix[0, width] = width; };
            

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
