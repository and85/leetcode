using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private int _setCounter = 0;
        public int CountComponents(int n, int[][] edges)
        {
            var sets = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < edges.Length; i++)
            {
                var set = new HashSet<int>();
                set.Add(edges[i][0]);
                set.Add(edges[i][1]);

                sets.Add(_setCounter++, set);
            }

            Iterate(n, sets);

            int isolatedNodes = 0;

            for (int i = 0; i < n; i++)
            {
                isolatedNodes += sets.Any(r => r.Value.Contains(i)) ? 0 : 1;
            }

            return sets.Count + isolatedNodes;
        }

        private void Iterate(int n, Dictionary<int, HashSet<int>> sets)
        {
            bool intersectionFound = false;

            foreach (var set1 in sets)
            {
                foreach (var set2 in sets)
                {
                    if (set1.Key == set2.Key)
                        continue;

                    intersectionFound = IntersectionFound(set1.Value, set2.Value);
                    if (intersectionFound)
                    {
                        Union(sets, set1.Key, set2.Key);
                        break;
                    }
                }

                if (intersectionFound) break;
            }

            if (intersectionFound)
                Iterate(n, sets);
        }

        private void Union(Dictionary<int, HashSet<int>> sets, int i, int j)
        {
            var unitedSet = sets[i].Union(sets[j]).ToHashSet();

            sets.Add(_setCounter++, unitedSet);
            sets.Remove(i);
            sets.Remove(j);
        }

        private bool IntersectionFound(HashSet<int> s1, HashSet<int> s2)
        {
            return s1.Any(s => s2.Contains(s));
        }
    }
}
