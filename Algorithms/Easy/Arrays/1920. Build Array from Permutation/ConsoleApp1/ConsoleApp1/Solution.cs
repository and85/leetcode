using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            return Optimal(nums);
            //return Naive(nums);
        }

        private static int[] Optimal(int[] nums)
        {
            //max element value is 999 by problem definition
            const int k = 1000;

            for (int i = 0; i < nums.Length; i++)
                //store a new value in the most significant digits of number keeping the old value in the least significant digits
                nums[i] += (nums[nums[i] % k] % k) * k;

            for (int i = 0; i < nums.Length; i++)
                //restore the new value from the most significant digits of number
                nums[i] = nums[i] / k;

            return nums;
        }

        private static int[] Naive(int[] nums)
        {
            // O(n) space
            int[] res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = nums[nums[i]];
            }

            return res;
        }
    }
}
