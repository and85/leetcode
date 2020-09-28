using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;
            int curSum = 0;
            int prevSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (prevSum + nums[i] > prevSum)
                {
                    prevSum += nums[i];
                }
                else
                {
                    prevSum = 0;
                }
                Console.WriteLine(prevSum);
            }

            return 0;
        }
    }
}
