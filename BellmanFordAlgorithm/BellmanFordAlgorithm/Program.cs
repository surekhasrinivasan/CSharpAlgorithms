using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellmanFordAlgorithm
{
    // Program to demo implementation of Bellman–Ford Algorithm for determining 
    // the shortest paths from a single source vertex to all of the other vertices 
    // in a weight graph
    class Program
    {
        public struct Edge
        {
            public int Source;
            public int Destination;
            public int Weight;
        }

        public struct Graph
        {
            public int VerticesCount;
            public int EdgesCount;
            public Edge[] edge;
        }

        static void Main(string[] args)
        {
        }
    }
}
