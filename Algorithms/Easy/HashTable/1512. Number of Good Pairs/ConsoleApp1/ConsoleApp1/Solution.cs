using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {

            // n * (n – 1) // 2
            var dict = nums.GroupBy(n => n).ToDictionary(n => n, n => n.Count());
            int sum = 0;
            foreach (var n in dict.Values)
                sum += n * (n - 1) / 2;

            return sum;
        }
    }
}
