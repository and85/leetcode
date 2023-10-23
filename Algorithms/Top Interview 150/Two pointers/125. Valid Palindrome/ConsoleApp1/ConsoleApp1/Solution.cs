using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;

            while (i < j)
            {
                if (!char.IsLetter(s[i]) && !char.IsDigit(s[i]))
                {
                    i++;
                    continue;
                }
                if (!char.IsLetter(s[j]) && !char.IsDigit(s[j]))
                {
                    j--;
                    continue;
                }

                if (char.ToLower(s[i]) != char.ToLower(s[j])) return false;
                i++;
                j--;
            }

            return true;
        }
    }
}
