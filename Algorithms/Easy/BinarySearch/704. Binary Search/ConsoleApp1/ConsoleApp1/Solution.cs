using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int median;

            while (low <= high)
            {
                median = low + (high - low) / 2;
                if (nums[median] == target)
                    return median;
                else if (nums[median] < target)
                    low = median + 1;
                else if (nums[median] > target)
                    high = median - 1;
            }

            return -1;
        }
    }
}
