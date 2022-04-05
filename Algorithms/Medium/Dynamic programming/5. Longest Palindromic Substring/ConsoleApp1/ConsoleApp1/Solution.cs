using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;

            string longest = s[0].ToString();

            for (int i = 0; i < s.Length; i++)
            {
                int l = i, r = i;

                while (l >=0 && r < s.Length)
                {
                    if (s[l] != s[r]) break;

                    string sub = s.Substring(l, r - l + 1);

                    if (sub.Length > longest.Length)
                    {
                        longest = sub;
                    }

                    l--;
                    r++;
                }
            }
            
            return longest;
        }
    }
}
