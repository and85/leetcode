using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            string[] parts = s
                .Split(' ')
                .Where(p => !string.IsNullOrWhiteSpace(p))
                .ToArray();
            Array.Reverse(parts);

            return string.Join(' ', parts);
        }
    }
}
