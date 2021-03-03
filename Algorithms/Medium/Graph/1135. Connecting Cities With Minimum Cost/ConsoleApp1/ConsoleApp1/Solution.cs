using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public class AdjListNode
        {
            public int Dest { get; set; }
            public int Weight { get; set; }
            public AdjListNode Next { get; set; }
        };

        public class AdjList
        {
            public AdjListNode Head { get; set; } // pointer to head node of list 
        };

        public class Graph
        {
            public int V { get; set; }
            public AdjList[] Array { get; set; }
        };

        // A utility function to create a new adjacency list node 
        AdjListNode NewAdjListNode(int dest, int weight)
        {
            AdjListNode newNode = new AdjListNode();             
            newNode.Dest = dest; 
            newNode.Weight = weight; 
            newNode.Next = null; 
            return newNode; 
        }

        // A utility function that creates a graph of V vertices 
        private Graph CreateGraph(int v)
        {
            Graph graph = new Graph(); 
            graph.V = v; 
  
            // Create an array of adjacency lists.  Size of array will be V 
            graph.Array = new AdjList[v]; 
  
            // Initialize each adjacency list as empty by making head as NULL 
            for (int i = 0; i < v; ++i) 
                graph.Array[i].Head = null; 
  
            return graph; 
        }

        private void AddEdge(Graph graph, int src, int dest, int weight) 
        { 
            // Add an edge from src to dest.  A new node is added to the adjacency 
            // list of src.  The node is added at the beginning 
            AdjListNode newNode = NewAdjListNode(dest, weight);
            newNode.Next = graph.Array[src].Head; 
            graph.Array[src].Head = newNode; 
  
            // Since graph is undirected, add an edge from dest to src also 
            newNode = NewAdjListNode(src, weight);
            newNode.Next = graph.Array[dest].Head; 
            graph.Array[dest].Head = newNode; 
        }

        // https://www.geeksforgeeks.org/prims-mst-for-adjacency-list-representation-greedy-algo-6/
        public int MinimumCost(int N, int[][] connections)
        {
            // using Prism algorithm we will find a minimum spanning tree whic will include vertexes 
            // reachable from the starting point, hence if the graph is not connected, some vertexes won't be visited
            // and we will return -1 in this case

            // https://yazankhalaileh.wordpress.com/2019/07/27/c-implementation-of-prims-algorithm-for-finding-a-minimum-spanning-tree/
            return 0;
        }
    }
}
