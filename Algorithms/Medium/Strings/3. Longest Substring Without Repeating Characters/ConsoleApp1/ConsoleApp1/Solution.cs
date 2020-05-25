using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var substring = new HashSet<char>();
            int i = 0, j = 0, maxLenght = 1;
            
            while (i < s.Length && j < s.Length)
            {
                if (!substring.Contains(s[j]))
                {
                    substring.Add(s[j++]);
                    //if (substring.Count > maxLenght)
                    //    maxLenght = substring.Count;
                    maxLenght = Math.Max(maxLenght, j - i);
                }
                else
                {
                    substring.Remove(s[i++]);
                }
            }

            return maxLenght;
        }
    }
}
