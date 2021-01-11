using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var result = new List<IList<int>>();

            var visited = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < graph.Length; i++)
                visited.Add(i, new HashSet<int>());

            int curr = 0, last = graph.Length - 1;
            
            var currSln = new LinkedList<int>();

            while (!AllChildNodesVisited(curr, graph, visited) || curr == last || IsDeadEnd(curr, last, graph))
            {
                currSln.AddLast(curr);

                if (IsDeadEnd(curr, last, graph))
                    curr = Backtrack(curr, last, graph, currSln, visited);

                if (curr == last)
                {
                    result.Add(currSln.ToList());
                    curr = Backtrack(curr, last, graph, currSln, visited);
                }

                curr = GetNextNode(curr, graph, visited);
            }

            return result;
        }

        private int Backtrack(int curr, int last, int[][] graph,  LinkedList<int> currSln, Dictionary<int, HashSet<int>> visited)
        {
            while (curr > 0)
            {
                visited[curr].Clear();
                currSln.RemoveLast();
                if (currSln.Count == 0)
                    break;

                curr = currSln.Last();

                if (!AllChildNodesVisited(curr, graph, visited))
                    break;
            }

            return curr;
        }

        private bool AllChildNodesVisited(int curr, int[][] graph, Dictionary<int, HashSet<int>> visited)
        {
            return graph[curr].All(n => visited[curr].Contains(n));
        }

        private bool IsDeadEnd(int curr, int last, int[][] graph)
        {
            return graph[curr].Length == 0 && curr != last;
        }

        private int GetNextNode(int curNode, int[][] graph, Dictionary<int, HashSet<int>> visited)
        {
            int nextNode = GetFirstNotVisitedNode(curNode, graph, visited);
            
            visited[curNode].Add(nextNode);

            return nextNode;
        }

        private static int GetFirstNotVisitedNode(int curNode, int[][] graph, Dictionary<int, HashSet<int>> visited)
        {
            return graph[curNode].FirstOrDefault(n => !visited[curNode].Contains(n));
        }
    }
}
