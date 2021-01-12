using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] res = new int[nums.Length];

            int p1 = 0, p2 = n;

            for (int i = 0; i < nums.Length; i += 2)
            {
                res[i] = nums[p1++];
                res[i + 1] = nums[p2++];
            }

            return res;
        }
    }
}
