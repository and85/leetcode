using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindMinArrowShots(int[][] points)
        {
            if (points.Length == 0)
                return 0;

            points = points.OrderBy(p => p[1]).ToArray();

            int arrows = 1, p = 0, i = 1;

            while (i < points.Length)
            {
                if (points[p][1] < points[i][0])
                {
                    arrows++;
                    p = i;
                }

                i++;
            }
            
            return arrows;
        }
    }
}
