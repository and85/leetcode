using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            int x1 = rec1[0];
            int y1 = rec1[1];
            int x2 = rec1[2];
            int y2 = rec1[3];

            int xx1 = rec2[0];
            int yy1 = rec2[1];
            int xx2 = rec2[2];
            int yy2 = rec2[3];

            // when one rectanle is located outside the other
            if (xx2 <= x1 || xx1 >= x2)
                return false;

            if (yy2 <= y1 || yy1 >= y2)
                return false;

            // when a rectangle looks like a line
            if (x1 == x2 || y1 == y2 || xx1 == xx2 || yy1 == yy2)
                return false;

            return true;
        }
    }
}
