﻿using System;
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

        public static Graph CreateGraph(int verticesCount, int edgesCount)
        {
            Graph graph = new Graph();
            graph.VerticesCount = verticesCount;
            graph.EdgesCount = edgesCount;
            graph.edge = new Edge[graph.EdgesCount];

            return graph;
        }

        private static void Print(int[]distance, int count)
        {
            Console.WriteLine("Vertex Distance from source");

            for(int i=0; i< count; i++)
                Console.WriteLine("{0}\t {1}", i, distance[i]);
        }

        static void Main(string[] args)
        {
        }
    }
}