using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int lastIndex = nums.Length - 1;

            int candidate1 = nums[lastIndex] * nums[lastIndex - 1] * nums[lastIndex - 2];

            int candidate2 = int.MinValue;
            int minNegative1 = nums[0];
            int minNegative2 = nums[1];
            int maxValue = nums[lastIndex];
            if (minNegative1 < 0 && minNegative2 < 0)
            {
                candidate2 = minNegative1 * minNegative2 * maxValue;
            }

            return Math.Max(candidate1, candidate2);
        }
    }
}
