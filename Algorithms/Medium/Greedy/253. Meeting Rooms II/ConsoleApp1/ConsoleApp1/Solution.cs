using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            if (intervals.Length == 0)
                return 0;

            int[] start = new int[intervals.Length];
            int[] end = new int[intervals.Length];

            for (int i = 0; i < intervals.Length; i++)
            {
                start[i] = intervals[i][0];
                end[i] = intervals[i][1];
            }

            Array.Sort(start, new IntervalComparer());
            Array.Sort(end, new IntervalComparer());

            int roomCounter = 0, startPointer = 0, endPointer = 0;

            while (startPointer < intervals.Length)
            {
                if (start[startPointer] >= end[endPointer])
                {
                    roomCounter--;
                    endPointer++;
                }

                roomCounter++;
                startPointer++;
            }

            return roomCounter;
        }

        public class IntervalComparer : Comparer<int>
        {
            public override int Compare(int x, int y)
            {
                return x.CompareTo(y);
            }
        }
    }
}
