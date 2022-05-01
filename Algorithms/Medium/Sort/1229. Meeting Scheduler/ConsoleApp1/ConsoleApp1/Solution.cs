using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)
        {
            Array.Sort(slots1, new IntervalComparer());
            Array.Sort(slots2, new IntervalComparer());

            int i = 0, j = 0;
            while (i < slots1.Length && j < slots2.Length)
            {
                int[] slot1 = slots1[i];
                int[] slot2 = slots2[j];
                if (Intersect(slot1, slot2))
                {
                    int minEnd = Math.Min(slot1[1], slot2[1]);
                    int maxStart = Math.Max(slot1[0], slot2[0]);
                    int intersectDirection = minEnd - maxStart;

                    if (intersectDirection >= duration)
                    {
                        return new List<int>() { maxStart, maxStart + duration };
                    }
                }

                if (slot1[1] < slot2[1])
                {
                    i++;
                }
                else if (slot2[1] < slot1[1])
                {
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }

            return new List<int>();
        }

        private bool Intersect(int[] slot1, int[] slot2)
        {
            return (slot1[0] >= slot2[0] && slot1[0] <= slot2[1]) || (slot2[0] >= slot1[0] && slot2[0] <= slot1[1]);
        }

        private class IntervalComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                int startX = x[0];
                int startY = y[0];


                if (startX != startY) return startX.CompareTo(startY);

                return x[1].CompareTo(y[1]);
            }
        }
    }
}
