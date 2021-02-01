using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    // very slow implementation, time Limit Exceeded
    public class Solution
    {
        public int CountComponents(int n, int[][] edges)
        {
            var sets = new List<List<int>>();
            for (int i = 0; i < edges.Length; i++)
            {
                var list = new List<int>();
                list.Add(edges[i][0]);
                list.Add(edges[i][1]);

                sets.Add(list);
            }

            var res = Iterate(n, sets);

            int isolatedNodes = 0;

            for (int i = 0; i < n; i++)
            {
                isolatedNodes += res.Any(r => r.Contains(i)) ? 0 : 1;
            }

            return res.Count + isolatedNodes;
        }

        private List<List<int>> Iterate(int n, List<List<int>> sets)
        {
            List<List<int>> res = new List<List<int>>();
            foreach (var set in sets)
                res.Add(set);

            bool intersectionFound = false;

            for (int i = 0; i < sets.Count; i++)
            {
                for (int j = i + 1; j < sets.Count; j++)
                {
                    intersectionFound = IntersectionFound(sets[i], sets[j]);
                    if (intersectionFound)
                    {
                        res = Union(sets, i, j);
                        break;
                    }
                }

                if (intersectionFound) break;
            }

            if (intersectionFound)
                res = Iterate(n, res);

            return res;
        }

        private List<List<int>> Union(List<List<int>> sets, int i, int j)
        {
            var unitedSet = sets[i].Union(sets[j]).ToList();
            var newSet = new List<List<int>>();
            newSet.Add(unitedSet);

            for (int s = 0; s < sets.Count; s++)
            {
                if (s != i && s != j)
                    newSet.Add(sets[s]);

            }

            return newSet;
        }

        private bool IntersectionFound(List<int> s1, List<int> s2)
        {
            return s1.Any(s => s2.Contains(s));
        }
    }
}
