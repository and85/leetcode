using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0, zeroIndex = -1;
            for (int p1 = 0, p2 = 0; p2 < nums.Length; p2++)
            {
                if (nums[p2] == 0)
                {
                    p1 = zeroIndex + 1;
                    zeroIndex = p2;
                }
                max = Math.Max(max, p2 - p1 + 1);
            }
            return max;
        }
    }
}
