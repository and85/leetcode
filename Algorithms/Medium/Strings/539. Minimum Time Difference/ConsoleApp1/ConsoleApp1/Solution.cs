using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            var times = timePoints
                .Select(t => DateTime.ParseExact(t, "HH:mm", System.Globalization.CultureInfo.InvariantCulture))
                .OrderBy(t => t)
                .ToArray();

            double diff; 
            double minDiff = times[0]
                .AddDays(1)
                .Subtract(times[times.Length - 1])
                .TotalMinutes;

            for (int i = 1; i < times.Length; i++)
            {
                diff = times[i].Subtract(times[i - 1]).TotalMinutes;

                if (diff < minDiff)
                    minDiff = diff;
            }

            return (int)minDiff;
        }
    }
}
