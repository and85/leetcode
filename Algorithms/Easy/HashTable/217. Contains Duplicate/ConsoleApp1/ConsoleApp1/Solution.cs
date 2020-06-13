using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();

            foreach (int num in nums)
            {
                if (hashSet.Contains(num))
                    return true;
                hashSet.Add(num);
            }

            return false;
        }
    }
}
