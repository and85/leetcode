using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length)
                return false;

            var dict1 = GetEntries(s);
            var dict2 = GetEntries(t);

            return CompareDictionaries(dict1, dict2);
        }

        private bool CompareDictionaries(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
        {
            if (dict1.Count != dict2.Count)
                return false;

            foreach (var d in dict1)
            {
                if (!dict2.ContainsKey(d.Key))
                    return false;

                if (d.Value != dict2[d.Key])
                    return false;
            }

            return true;
        }

        private Dictionary<char, int> GetEntries(string s)
        {
            var result = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (result.ContainsKey(c))
                    result[c]++;
                else
                    result.Add(c, 1);
            }
            
            return result;
        }
    }
}
