using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            var dict = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], t[i]);
                }
                else
                {
                    if (dict[s[i]] != t[i])
                        return false;
                }
            }

            bool duplicateValuesExist = dict.GroupBy(x => x.Value).Any(x => x.Count() > 1);


            return !duplicateValuesExist;
        }
    }
}
