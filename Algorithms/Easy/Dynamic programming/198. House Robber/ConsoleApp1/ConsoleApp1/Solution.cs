using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Rob_Attempt3(int[] nums)
        {
            return 0;
        }


        public int Rob_Attempt2(int[] nums)
        {
            int[] dp = new int[nums.Length + 1];
            dp[0] = 0;
            dp[1] = nums[0];

            for (int i = 2; i < dp.Length; i++)
            {
                dp[i] = Math.Max(nums[i - 1] + dp[i - 2], dp[i - 1]);
            }

            return dp[nums.Length];
        }

        public int Rob_Attempt1(int[] nums)
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
