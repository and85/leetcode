using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var numHashSet = new HashSet<int>();
            var resHashSet = new HashSet<int>();
            foreach (int num in nums1)
            {
                if (!numHashSet.Contains(num))
                    numHashSet.Add(num);
            }

            foreach (int num in nums2)
            {
                if (numHashSet.Contains(num))
                    resHashSet.Add(num);
            }

            int[] res = new int[resHashSet.Count];
            resHashSet.CopyTo(res);

            return res;
        }
    }
}
