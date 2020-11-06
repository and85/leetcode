using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] leftProducts = new int[nums.Length];
            int[] rightProducts = new int[nums.Length];

            leftProducts[0] = 1;
            rightProducts[nums.Length - 1] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                leftProducts[i] = leftProducts[i - 1] * nums[i - 1];
            }

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                rightProducts[i] = rightProducts[i + 1] * nums[i + 1];
            }

            for (int i = 0 ; i < nums.Length; i++)
            {
                nums[i] = leftProducts[i] * rightProducts[i];
            }

            return nums;
        }
    }
}
