using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue, curSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                curSum = Math.Max(nums[i], curSum + nums[i]);
                maxSum = Math.Max(maxSum, curSum);
            }

            return maxSum;
        }

        public int MaxSubArray_Attempt1(int[] nums)
        {
            int n = nums.Length, maxSum = nums[0];
            for (int i = 1; i < n; ++i)
            {
                if (nums[i - 1] > 0) 
                    nums[i] += nums[i - 1];
                
                maxSum = Math.Max(nums[i], maxSum);
            }

            return maxSum;
        }
    }
}
