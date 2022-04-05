using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NumDecodings(string s)
        {
            return Recursive(0, s);
        }

        private int Recursive(int index, string s)
        {
            if (index == s.Length - 1) return 1;

            if (s[index] == '0') return 0;

            int res = Recursive(0, s.Substring(index + 1, s.Length - index - 1));
            res += (int.Parse(s.Substring(0, 2)) <= 26) ? 1 : 0;

            return res;
        }
    }
}
