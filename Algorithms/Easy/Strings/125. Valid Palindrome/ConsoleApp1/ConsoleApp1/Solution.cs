using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            int l = 0, r = s.Length - 1;

            while (l < r)
            {
                if (char.ToLower(s[l]) == char.ToLower(s[r]))
                {
                    l++;
                    r--;
                    continue;
                }
                else if (!char.IsLetterOrDigit(s[l]))
                {
                    l++;
                }
                else if (!char.IsLetterOrDigit(s[r]))
                {
                    r--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
