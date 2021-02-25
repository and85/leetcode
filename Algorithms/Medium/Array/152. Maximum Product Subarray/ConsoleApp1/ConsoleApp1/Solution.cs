using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        // Kadane's algorithm
        public int MaxProduct(int[] nums)
        {
			int n = nums.Length;
			int max = nums[0];
			int min = nums[0];
			
			int ans = 0;
			for (int i = 1; i < n; i++)
			{
				if (Math.Abs(max * nums[i]) > Math.Abs(min))
					min = Math.Min(nums[i], min * nums[i]);

				max = Math.Max(nums[i], max * nums[i]);

				

				//mn = Math.Min(nums[i], mn * nums[i]);

				//ans = Math.Max(ans, Math.Max(Math.Abs(mn), mx));
			}
			return ans;
		}
    }
}
