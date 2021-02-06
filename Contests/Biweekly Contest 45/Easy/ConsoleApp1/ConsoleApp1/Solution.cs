using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int SumOfUnique(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            foreach (int i in nums)
            {
                if (dict.ContainsKey(i))
                    dict[i]++;
                else
                    dict.Add(i, 1);
            }

            int sum = 0;

            foreach (var k in dict)
            {
                if (k.Value > 1)
                    continue;
                sum += k.Key;
            }

            return sum;
        }
    }
}
