using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int ThirdMax(int[] nums)
        {
            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;

            max1 = FindMax(nums, max1, int.MaxValue, out bool _);
            max2 = FindMax(nums, max2, max1, out bool _);
            max3 = FindMax(nums, max3, max2, out bool max3Found);

            return (max3Found) ? max3 : max1;
        }

        private int FindMax(int[] nums, int max, int prevMax, out bool found)
        {
            found = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= max && nums[i] < prevMax)
                {
                    found = true;
                    max = nums[i];
                }
            }

            return max;
        }
    }
}
