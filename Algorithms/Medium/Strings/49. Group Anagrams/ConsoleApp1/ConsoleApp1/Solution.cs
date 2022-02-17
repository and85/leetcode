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
            var result = new List<IList<string>>();
            var grouped = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                string key = GetKey(str);
                if (grouped.ContainsKey(key))
                {
                    grouped[key].Add(str);
                }
                else
                {
                    grouped.Add(key, new List<string>() { str });
                }
            }

            foreach (var g in grouped)
            {
                result.Add(g.Value);
            }
            
            return result;
        }

        private string GetKey(string str)
        {
            var sb = new StringBuilder();

            int[] counts = new int[26];
            foreach (var c in str)
            {
                counts[c - 'a']++;
            }
            
            foreach (var i in counts)
            {
                sb.Append(i);
                sb.Append('|');
            }

            return sb.ToString();
        }
    }
}
