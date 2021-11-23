using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution_attempt1
    {
        public int NumIdenticalPairs(int[] nums)
        {
            //return Solution_attempt11(nums);

            int res = 0;
            var dict = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                res += dict.ContainsKey(num) ? dict[num] : 0;                
                if (dict.ContainsKey(num))
                    dict[num]++;
                else 
                    dict.Add(num, 1);
            }
            return res;
        }

        private static int Solution_attempt11(int[] nums)
        {
            var dict = nums.GroupBy(n => n).ToDictionary(n => n, n => n.Count());
            int sum = 0;
            foreach (var n in dict.Values)
                sum += n * (n - 1) / 2;

            return sum;
        }
    }
}
