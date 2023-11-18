using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            var words = s.Split(" ");
            var dict = new Dictionary<char, string>();
            var hashSet = new HashSet<string>();

            if (words.Length != pattern.Length) return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dict.ContainsKey(pattern[i]))
                {
                    dict.Add(pattern[i], words[i]);

                    if (hashSet.Contains(words[i])) return false;

                    hashSet.Add(words[i]);
                }
                else
                {
                    if (dict[pattern[i]] != words[i]) return false;
                }
            }

            return true;
        }
    }   
}
