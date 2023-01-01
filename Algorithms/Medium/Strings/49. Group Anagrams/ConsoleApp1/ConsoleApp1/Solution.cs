using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                string key = GetKey(str);
                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<string>());
                }

                dict[key].Add(str);
            }


            return dict.Select(g => g.Value).ToList();
        }

        private string GetKey(string str)
        {
            int[] counts = new int[26];

            foreach (var c in str)
            {
                counts[c - 'a']++;
            }

            return string.Join('|', counts);
        }
    }
}
