using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool ValidPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;            

            while (i < j)
            {
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                    continue;
                }
                

                if (s[i + 1] == s[j])
                {
                    if (IsPalindrome(s, i + 1, j)) return true;
                }

                if (s[j - 1] == s[i])
                {
                    if (IsPalindrome(s, i, j - 1)) return true;
                }

                return false;                

            }

            return true;
        }

        private bool IsPalindrome(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i] != s[j]) return false;
                i++;
                j--;
            }

            return true;
        }

        public bool ValidPalindrome_Attempt1(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;

            s = string.Join("", s.ToCharArray()
                .Where(c => Char.IsLetterOrDigit(c))
                .Select(c => c.ToString().ToLower()));

            if (s.Length == 1)
                return true;
            return IsPalindrome(s, 0);
        }

        private static bool IsPalindrome(string s, int recursionLevel)
        {
            if (recursionLevel > 1)
                return false;

            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                {
                    string candidate1 = s.Substring(0, i) + s.Substring(i + 1, s.Length - i - 1);
                    string candidate2 = s.Substring(0, j) + s.Substring(j + 1, s.Length - j - 1);
                    return IsPalindrome(candidate1, recursionLevel + 1) || IsPalindrome(candidate2, recursionLevel + 1);
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
