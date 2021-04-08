using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int TwoSumLessThanK(int[] nums, int k)
        {
            Array.Sort(nums);

            int left = 0, right = nums.Length - 1, curSum, maxSum = 0;

            while (left < right)
            {
                curSum = nums[left] + nums[right];                

                if (curSum < k)
                {
                    maxSum = Math.Max(maxSum, curSum);
                    left++;
                }

                if (curSum >= k)
                {
                    right--;
                }
            }

            return maxSum > 0 ? maxSum : -1;
        }
    }
}
