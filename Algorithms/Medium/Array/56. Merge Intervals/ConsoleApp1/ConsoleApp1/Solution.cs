using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
                return intervals;

            Array.Sort(intervals, new IntervalComparer());

            var intervalStack = new Stack<int[]>();
            intervalStack.Push(intervals[0]);

            for (int i = 1; i < intervals.Length; i++)
            {
                if (IntervalsOverlap(intervalStack.Peek(), intervals[i], out int[] newInterval))
                {
                    intervalStack.Pop();
                    intervalStack.Push(newInterval);
                }
                else
                {
                    intervalStack.Push(intervals[i]);
                }
            }

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

        class IntervalComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                return x[0].CompareTo(y[0]);
            }
        }
    }
}
