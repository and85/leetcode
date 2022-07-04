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
            int[] chars = new int[128];
            for (int i = 0; i < 128; i++)
            {
                chars[i] = -1;
            }

            int left = 0;
            int right = 0;

            int res = 0;
            while (right < s.Length)
            {
                char r = s[right];

                int index = chars[r];
                if (index != -1 && index >= left && index < right)
                {
                    left = index + 1;
                }

                res = Math.Max(res, right - left + 1);

                chars[r] = right;
                right++;
            }

            return res;
        }

        private static int Attempt2(string s)
        {
            int maxLength = 0;
            var hashSet = new HashSet<char>();

            int windowStart = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!hashSet.Contains(s[i]))
                {
                    hashSet.Add(s[i]);
                }
                else
                {
                    int j = windowStart;
                    while (s[j] != s[i])
                    {
                        hashSet.Remove(s[j++]);
                    }

                    windowStart = j + 1;

                }

                maxLength = Math.Max(maxLength, i - windowStart + 1);
            }

            return maxLength;
        }

        public int LengthOfLongestSubstring_Attempt1(string s)
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
