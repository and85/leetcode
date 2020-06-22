using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {

        private class Entry
        {
            public Entry(int firstIndex)
            {
                FirstIndex = firstIndex;
            }

            public int FirstIndex { get; set; }
            public int Count { get; set; }
        }

        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, Entry>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], new Entry(i));
                else
                    dict[s[i]].Count++;
            }

            int res = -1;
            if (dict.Any(e => e.Value.Count == 0))
            {
                res = dict.Where(e => e.Value.Count == 0)
                    .OrderBy(e => e.Value.FirstIndex)
                    .First().Value.FirstIndex;
            }

            return res;
        }
    }
}
