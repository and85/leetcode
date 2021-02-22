using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public String longestNiceSubstring(String s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return string.Empty;

            string longest = string.Empty;
            string sub = string.Empty;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            for (int j = i; j < arr.Length; j++)
            {
                sub = s.Substring(i, j - i + 1);
                //if (sub.Length == s.Length)
                //    continue;

                if (IsGood(sub) && sub.Length > longest.Length)
                    longest = sub;

            }

            return longest;
        }

        private bool IsGood(string s)
        {
            (bool, bool)[] res = new (bool, bool)[26];
            char c;
            for (int i = 0; i < s.Length; i++)
            {
                c = s[i];
                if (char.IsLower(c))
                {
                    res[c - 97].Item1 = true;
                }

                if (char.IsUpper(c))
                {
                    res[char.ToLower(c) - 97].Item2 = true;
                }                
            }

            for (int i = 0; i < res.Length; i++)
            {
                if ((res[i].Item1 == false && res[i].Item2 == true)
                    || (res[i].Item2 == false && res[i].Item1 == true))
                        return false;
            }

            return true;
        }
    }
}
