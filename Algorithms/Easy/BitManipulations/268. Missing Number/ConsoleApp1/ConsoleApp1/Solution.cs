using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            int result = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i] ^ i;
            }

            return result;
        }
    }
}
