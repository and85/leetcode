using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (target < nums[0])
                return 0;
            if (target > nums[nums.Length - 1])
                return nums.Length;

            int l = 0, h = nums.Length - 1, m;
            while (h - l > 1)
            {
                m = l + (h - l) / 2;

                if (nums[m] > target)
                {
                    h = m - 1;
                }
                else if (nums[m] < target)
                {
                    l = m + 1;
                }
                else
                    return m;
            }

            if (target > nums[h])
                return h + 1;
            else if (target > nums[l])
                return l + 1;
            else
                return l;
        }
    }
}
