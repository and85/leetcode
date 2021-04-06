using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            var orderedCounts = index.OrderBy(i => i).GroupBy(i => i).ToDictionary(i => i.Key, i => i.Count());

            var endPositions = new Dictionary<int, int>();
            int prevPos, prevEnd = 0;

            foreach (var c in orderedCounts)
            {
                prevPos = c.Key - 1;
                if (orderedCounts.ContainsKey(prevPos) && endPositions.ContainsKey(prevPos))
                {
                    prevEnd = endPositions[prevPos];
                }

                endPositions.Add(c.Key, c.Value + prevEnd);
            }



            return null;
        }
    }
}
