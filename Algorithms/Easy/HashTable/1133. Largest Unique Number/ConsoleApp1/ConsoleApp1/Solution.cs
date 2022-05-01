using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int LargestUniqueNumber(int[] nums)
        {
            return nums.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count()).Where(n => n.Value == 1).DefaultIfEmpty(new KeyValuePair<int, int>(-1, -1)).Max(n => n.Key);
        }
    }
}
