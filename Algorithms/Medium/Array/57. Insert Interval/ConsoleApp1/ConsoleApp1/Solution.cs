using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            // 1. use binary search to find a position where a new interval should be inserted 
            // (it could be either at the begining, at the end or at the middle of the array)
            // 2. if new interval overlaps with found interval - merge
            // 3. if new interval doesn't overlap with interval from the found position, insert a new interval to a proper position 
            // (expand of the array and shift required elements either to the left or to the right)


        }
    }
}
