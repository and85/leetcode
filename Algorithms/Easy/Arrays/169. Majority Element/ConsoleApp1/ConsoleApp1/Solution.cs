using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            // brute force
            //return nums.GroupBy(x => x)
            //    .ToDictionary(x => x.Key, x => x.Count())
            //    .Where(x => x.Value > nums.Length / 2)
            //    .First()
            //    .Key;

            // Boyer-Moore O(n) time, O(1) space

            int counter = 0, candidate = -1;
            foreach (int n in nums)
            {
                if (counter == 0)
                {
                    candidate = n;
                }

                counter += (n == candidate) ? 1 : -1;
            }

            return candidate;            
        }
    }
}
