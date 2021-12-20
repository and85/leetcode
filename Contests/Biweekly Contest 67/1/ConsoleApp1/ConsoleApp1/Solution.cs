using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // task 1
    public class Solution
    {
        class Num
        {
            public int Value { get; set; }
            public int Index { get; set; }
        }

        public int[] MaxSubsequence(int[] nums, int k)
        {
            Num[] values = new Num[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                values[i] = new Num() { Value = nums[i], Index = i };
            }

            int m = nums.Length - k;
            
            var sorted = values.OrderByDescending(v => v.Value).Take(k).ToArray();
            sorted = sorted.OrderBy(v => v.Index).ToArray();

            int r = 0;
            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = sorted[i].Value;
            }

            return result;
        }
    }
}
