using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindKthLargest(int[] nums, int k)
        {
            Array.Sort(nums, (int m, int n) => { return n - m; });
            return nums[k - 1];
        }
    }
}
