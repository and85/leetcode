using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);

            int maxSum = 0;
            for (int i = 0; i < nums.Length; i += 2)
            {
                maxSum += nums[i];
            }

            return maxSum;
        }
    }
}
