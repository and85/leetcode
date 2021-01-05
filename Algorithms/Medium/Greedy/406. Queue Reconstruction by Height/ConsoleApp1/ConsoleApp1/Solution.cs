using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[][] ReconstructQueue(int[][] people)
        {
            var orderedPpl = new List<int[]>();

            // O(n log(n))
            people = people
                .OrderByDescending(p => p[0])
                .ThenBy(p => p[1])
                .ToArray();

            // O(n^2), because Insert operation is O(n) for a list)
            foreach (var p in people)
            {
                if (orderedPpl.Count == 0 || p[0] >= orderedPpl[orderedPpl.Count - 1][0])
                    orderedPpl.Add(p);
                else
                    orderedPpl.Insert(p[1], p);
            }

            return orderedPpl.ToArray();
        }
    }
}
