using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public class Graph
        {
            private int _verticesNumber; 
            private List<int>[] _adjacencyList;  

            public Graph(int n)
            {
                _verticesNumber = n;
                _adjacencyList = new List<int>[n];
                for (int i = 0; i < n; i++)
                    _adjacencyList[i] = new List<int>();
            }

            public void AddEdge(int v, int w)
            {
                _adjacencyList[v].Add(w);
                _adjacencyList[w].Add(v);
            }

            public bool IsTree()
            {
                bool[] visited = CreateUnvisitedVeretices();

                if (IsCycleExist(0, visited, -1) || NotVisitedVertexExist(visited))
                    return false;

                return true;
            }

            private bool[] CreateUnvisitedVeretices()
            {
                bool[] visited = new bool[_verticesNumber];
                for (int i = 0; i < _verticesNumber; i++)
                    visited[i] = false;
                return visited;
            }

            private bool NotVisitedVertexExist(bool[] visited)
            {
                for (int i = 0; i < _verticesNumber; i++)
                {
                    if (!visited[i])
                        return true;
                }

                return false;
            }

            private bool IsCycleExist(int node, bool[] visited, int parent)
            {
                VisitNode(node, visited);
                
                foreach (int adjacentNode in _adjacencyList[node])
                {
                    if (!visited[adjacentNode])
                    {
                        if (IsCycleExist(adjacentNode, visited, node))
                            return true;
                    }
                    else if (IsNotParentRefernce(adjacentNode, parent))
                        return true;
                }

                return false;
            }

            private bool IsNotParentRefernce(int adjacentNode, int parent)
            {
                return adjacentNode != parent;
            }

            private void VisitNode(int node, bool[] visited)
            {
                visited[node] = true;
            }
        }

        public bool ValidTree(int n, int[][] edges)
        {
            Graph graph = ConstructGraph(n, edges);
            return graph.IsTree();
        }

        private Graph ConstructGraph(int n, int[][] edges)
        {
            var graph = new Graph(n);
            for (int i = 0; i < edges.Length; i++)
            {
                graph.AddEdge(edges[i][0], edges[i][1]);
            }

            return graph;
        }
    }
}
