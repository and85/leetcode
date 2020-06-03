using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            SortByIntervalStart(intervals);

            for (int i = 1; i < intervals.Length; i++)
            {
                if (IsStartOverlapWithPreviousEnd(intervals, i))
                    return false;
            }

            return true;
        }

        private bool IsStartOverlapWithPreviousEnd(int[][] intervals, int i)
        {
            return intervals[i][0] <= intervals[i - 1][1];
        }

        private void SortByIntervalStart(int[][] intervals)
        {
            Array.Sort(intervals, new Comparison<int[]>(
                (x, y) => { return x[0] < y[0] ? -1 : (x[0] > y[0] ? 1 : 0); }
                ));
        }
    }
}
