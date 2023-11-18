using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length > t.Length) return false;

            int i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] != t[j])
                {
                    j++;
                    continue;
                }
                i++;
                j++;
            }

            return i == s.Length;
        }
    }
}
