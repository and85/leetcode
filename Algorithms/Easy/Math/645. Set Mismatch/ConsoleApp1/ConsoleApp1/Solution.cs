using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 1; i <= nums.Length; i++)
                dict.Add(i, 0);

            for (int i = 0; i < nums.Length; i++)
                dict[nums[i]]++;

            return new int[]
            {
                dict.Single(num => num.Value == 2).Key,
                dict.Single(num => num.Value == 0).Key
            };
        }
    }
}
