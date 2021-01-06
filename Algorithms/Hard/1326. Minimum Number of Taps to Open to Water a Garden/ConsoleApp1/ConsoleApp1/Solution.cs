using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MinTaps(int n, int[] ranges)
        {
            var intervals = new Interval[ranges.Length];
            for (int i = 0; i < ranges.Length; i++)
            {
                intervals[i] = new Interval(n, i - ranges[i], i + ranges[i]);
            }

            intervals = intervals
                .OrderBy(i => i.Start)
                .ThenByDescending(i => i.End)
                .ToArray();

            int taps = 1;
            var covered = intervals[0];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i].Start > covered.End)
                    return -1;

                if (intervals[i].End > covered.End)
                {
                    covered.End = intervals[i].End;
                    taps++;
                }
            }

            return covered.End >= n ? taps : -1;
        }

        public class Interval
        {
            private int _start;
            private int _end;

            public Interval(int maxEnd, int start, int end)
            {
                MaxEnd = maxEnd;
                Start = start;
                End = end;
            }

            public int Start
            {
                get => _start;
                set => _start = value >= 0 ? value : 0;
            }
            public int End
            {
                get => _end;
                set => _end = value <= MaxEnd ? value : MaxEnd;
            }

            public int MaxEnd
            {
                get;
                set;
            }
        }
    }
}
