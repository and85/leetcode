using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length <= 1)
                return intervals;

            var intervalStack = new Stack<int[]>();
           
            // todo: we should check in a loop if intervals overlap?

            var merged = intervalStack.ToArray();
            Array.Reverse(merged);

            return merged;
        }

        private bool IntervalsOverlap(int[] interval1, int[] interval2, out int[] newInterval)
        {
            bool isOverlap = (interval1[1] >= interval2[0] && interval1[1] <= interval2[1]) ||
                (interval2[1] >= interval1[0] && interval2[1] <= interval1[1]);
           
            newInterval = new int[2] 
            { 
                Math.Min(interval1[0], interval2[0]),
                Math.Max(interval1[1], interval2[1]),
            }; 

            return isOverlap;
        }
    }
}
