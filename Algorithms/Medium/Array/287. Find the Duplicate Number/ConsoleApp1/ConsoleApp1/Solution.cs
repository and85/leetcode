using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();

            foreach (int num in nums)
            {
                if (hashSet.Contains(num))
                    return num;
                else
                    hashSet.Add(num);
            }

            return -1;
        }
    }
}
