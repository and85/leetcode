using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    nums[0] ^= nums[i];
            //}

            //return nums[0];

            int result = 0;
            Array.ForEach(nums, x => nums[0] ^= x);
            return result;
        }
    }
}
