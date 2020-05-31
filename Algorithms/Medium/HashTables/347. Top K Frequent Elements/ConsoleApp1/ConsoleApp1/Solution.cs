using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var entriesFrequency = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (!entriesFrequency.ContainsKey(num))
                    entriesFrequency.Add(num, 1);
                else
                    entriesFrequency[num]++;
            }

            return entriesFrequency.OrderByDescending(o => o.Value)
                .Take(k)
                .Select(f => f.Key)
                .ToArray();
        }
    }
}
