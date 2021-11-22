using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;

            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (nums[m] == target) return m;

                if (target > nums[m])
                    l = m + 1;
                else
                    r = m - 1;
            }
            
            return -1;
        }
    }
}
