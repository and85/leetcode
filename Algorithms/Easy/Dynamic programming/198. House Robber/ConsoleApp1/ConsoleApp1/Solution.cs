using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int prevMax = 0;
            int curMax = 0;

            foreach (int n in nums)
            {
                int temp = curMax;
                curMax = Math.Max(prevMax + n, curMax);
                prevMax = temp;
            }

            return curMax;
        }
    }
}
