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
			int curProduct = nums[0];
			int curProductMin = nums[0];
			int max = nums[0];
			

			for (int i = 1; i < n; i++)
			{
				int tmp = curProduct;
				curProduct = Math.Max(nums[i], Math.Max(tmp * nums[i], curProductMin * nums[i]));
				curProductMin = Math.Min(nums[i], Math.Min(curProductMin * nums[i], tmp * nums[i]));

				max = Math.Max(max, curProduct);
			}
			return max;
		}
    }
}
