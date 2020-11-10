using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int sIndex = 0;
            StringBuilder sb = new StringBuilder();

            foreach (char c in t)
            {
                if (sIndex >= s.Length)
                    break;

                if (s[sIndex] == c)
                {
                    sb.Append(c);
                    sIndex++;
                }
            }

            return s.Equals(sb.ToString());
        }
    }
}
