using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool BackspaceCompare(string s, string t)
        {
            int max = Math.Max(s.Length, t.Length);

            var sB = new StringBuilder();
            var tB = new StringBuilder();

            for (int i = 0; i < max; i++)
            {
                EnterSymbol(s, sB, i);
                EnterSymbol(t, tB, i);
            }

            return sB.Equals(tB);
        }

        private void EnterSymbol(string s, StringBuilder sB, int i)
        {
            if (i >= s.Length) return;

            if (s[i] != '#')
            {
                sB.Append(s[i]);
            }
            else
            {
                if (sB.Length > 0)
                {
                    sB.Remove(sB.Length - 1, 1);
                }
            }
        }
    }
}
