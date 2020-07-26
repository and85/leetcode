using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            var te = GetEntries(t);
            var se = GetEntries(s);

            return te.Where(e => !se.ContainsKey(e.Key) || te[e.Key] > se[e.Key]).Single().Key;
        }

        private Dictionary<char, int> GetEntries(string str)
        {
            var entries = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (entries.ContainsKey(c))
                    entries[c]++;
                else
                    entries.Add(c, 1);
            }

            return entries;
        }
    }
}
