using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;

            s = string.Join("", s.ToCharArray()
                .Where(c => Char.IsLetterOrDigit(c))
                .Select(c => c.ToString().ToLower()));

            if (s.Length == 1)
                return true;

            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i]!= s[j])
                    return false;
                
                i++;
                j--;
            }

            return true;
        }
    }
}
