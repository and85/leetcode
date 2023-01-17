using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int curSum = 0;
            int maxSum = 0;
            for (int i = 0; i < k; i++)
            {
                curSum += nums[i];
            }

            maxSum = curSum;

            for (int i = k; i < nums.Length; i++)
            {
                curSum += nums[i] - nums[i - k];
                maxSum = Math.Max(curSum, maxSum);
            }

            return (double)maxSum / k;
        }
    }
}
