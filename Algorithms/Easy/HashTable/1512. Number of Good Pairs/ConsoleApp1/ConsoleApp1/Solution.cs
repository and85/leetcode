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
            int res = 0;

            var dict = new Dictionary<int, int>();
            foreach (int n in nums)
            {

                // 1 - 0 (1) res 0
                // 1 1 - 1 (2) res 1
                // 1 1 1 - 2 (3) res 1 + 2 = 3
                // 1 1 1 1 - 3 (4) res 3 + 3
                if (dict.ContainsKey(n))
                {
                    res += dict[n];
                    dict[n]++;
                }
                else
                    dict.Add(n, 1);
            }

            return res;
        }
    }
}
