using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaxAbsoluteSum(int[] nums)
        {
			int n = nums.Length;
			int mn = 0;
			int mx = 0;
			int ans = 0;
			for (int i = 0; i < n; i++)
			{
				mx = Math.Max(0, mx + nums[i]);

				mn = Math.Min(nums[i], mn + nums[i]);

				ans = Math.Max(ans, Math.Max(Math.Abs(mn), mx));
			}
			return ans;
		}
    }
}
