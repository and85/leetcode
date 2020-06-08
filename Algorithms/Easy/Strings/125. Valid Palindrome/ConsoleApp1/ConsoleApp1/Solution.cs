using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return true;

            if (s.Length == 1)
                return true;

            int i = 0, j = s.Length - 1;
            int first = i, last = j;
            bool set = false;

            while (i < j)
            {
                if (!char.IsLetter(s[i]))
                {
                    i++;
                    continue;
                }
                
                if (!char.IsLetter(s[j]))
                {
                    j--;
                    continue;
                }

                if (s[i].ToString().ToLower() != s[j].ToString().ToLower())
                    return false;
                
                if (!set)
                {
                    first = i;
                    last = j;
                    set = true;
                }
                i++;
                j--;
            }

            return true && (s[first].ToString().ToLower() == s[last].ToString().ToLower()) && first != last;
        }
    }
}
