using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string RemoveVowels(string s)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0) continue;

                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
