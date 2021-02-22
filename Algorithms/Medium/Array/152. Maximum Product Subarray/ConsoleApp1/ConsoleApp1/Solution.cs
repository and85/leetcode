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
            int max = nums[0];            
            int currentProduct = nums[0];
            int currentProductMin = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentProduct = Math.Max(nums[i], Math.Max(currentProduct * nums[i], currentProductMin * nums[i]));
                currentProductMin = Math.Min(nums[i], currentProductMin * nums[i]);
                max = Math.Max(max, currentProduct);
            }

            return max;
        }
    }
}
