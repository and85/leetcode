using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var dict1 = nums1.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());
            var dict2 = nums2.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());
            
            foreach (var n in dict1.ToList())
            {
                if (dict2.ContainsKey(n.Key))
                {
                    dict1[n.Key] = Math.Min(dict1[n.Key], dict2[n.Key]);
                }
                else
                    dict1.Remove(n.Key);
            }

            var resultList = new List<int>();
            foreach (var n in dict1)
            {
                for (int i = 0; i < n.Value; i++)
                    resultList.Add(n.Key);
            }

            return resultList.ToArray();
        }
    }
}
