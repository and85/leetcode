using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool HalvesAreAlike(string s)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int l = 0, r = s.Length - 1, lc = 0, rc = 0;

            while ( l < r)
            {
                if (vowels.Contains(s[l++])) lc++;
                if (vowels.Contains(s[r--])) rc++;
            }

            return lc == rc;
        }
    }
}
