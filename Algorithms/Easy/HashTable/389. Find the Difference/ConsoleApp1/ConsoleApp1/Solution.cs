using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            var hashSet = new HashSet<char>(s);
            foreach (char c in t)
            {
                if (!hashSet.Contains(c))
                    return c;
            }

            return '\0';
        }
    }
}
