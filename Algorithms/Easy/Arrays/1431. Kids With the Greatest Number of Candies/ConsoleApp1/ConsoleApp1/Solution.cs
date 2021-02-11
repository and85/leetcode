using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var res = new List<bool>();
            int max = candies.Max();

            foreach (var c in candies)
            {
                res.Add(c + extraCandies >= max);
            }

            return res;
        }
    }
}
