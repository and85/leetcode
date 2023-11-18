using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dict = new Dictionary<char, char>();
            var used = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    if (used.Contains(t[i])) return false;
                    dict.Add(s[i], t[i]);
                    used.Add(t[i]);
                }
                else
                {
                    
                    if (t[i] != dict[s[i]]) return false;
                }
            }

            return true;
        }
    }
}
