using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private System.Collections.Concurrent.ConcurrentDictionary<string, int> _substringCount 
            = new System.Collections.Concurrent.ConcurrentDictionary<string, int>();
        private static string LongestSubstring;
        
        private int _median;

        public string LongestDupSubstring(string s)
        {
            LongestSubstring = string.Empty;
            _median = s.Length / 2;

            CountSubstrings(s);

            return LongestSubstring; 
        }

        private void CountSubstrings(string s)
        {
            var tasks = new List<System.Threading.Tasks.Task>();

            for (int i = 0; i < s.Length; i++)
            {
                string sub = s.Substring(i, s.Length - i);
                tasks.Add(System.Threading.Tasks.Task.Factory.StartNew(() => GenerateSubstrings(sub)));
            }

            System.Threading.Tasks.Task.WaitAll(tasks.ToArray());
        }

        private void GenerateSubstrings(string s)
        {
            int maxSubstringLenght = Math.Min(_median, s.Length);

            StringBuilder substring = new StringBuilder(maxSubstringLenght);
            for (int i = 0; i < maxSubstringLenght; i++)
            {
                substring.Append(s[i]);
                UpdateCounter(substring.ToString());
            }
        }

        private void UpdateCounter(string key)
        {
            if (!_substringCount.TryAdd(key, 1))
            {
                if (key.Length > LongestSubstring.Length)
                    LongestSubstring = key;
            }
        }
    }
}
