using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        /*
        [0, 1] [1, 3] [3, 5] [2, 7] [3, 2] [4, 6]  O(n^3) ?

        [0, 1, 3] 


        Public iterate(sets)

        {
        if (UnionFound) => Union
           Iterate(sest)

        If (unionNotFound)
        Return sets.Count
        }

        0
        |
        1   -  3   - 5
                |
                2 - 7


        4  -  6

        */
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

            return res.Count;
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
                Iterate(n, res);

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
