using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            var sd = s
                .GroupBy(c => c)
                .ToDictionary(grp => grp.Key, grp => grp.Count());
            foreach(var tt in t)
            {
                if (sd.ContainsKey(tt))
                {
                    sd[tt]--;
                }
                else
                {
                    return false;
                }
            }

            foreach (var sdd in sd)
            {
                if (sd[sdd.Key] != 0) return false;
            }

            return true;

        }
    }
}
