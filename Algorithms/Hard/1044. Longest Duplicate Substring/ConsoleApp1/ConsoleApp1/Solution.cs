using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    // not my solution. took from 
    //https://leetcode.com/problems/longest-duplicate-substring/discuss/696057/c-faster-than-100.00-of-C-//submissions-O(n-log-n)
    public class Solution
    {
        public string LongestDupSubstring(string s)
        {
            var longestSubstring = string.Empty;
            var n = s.Length;

            var left = 1;
            var right = n;
            while (left <= right)
            { 
                var mid = left + (right - left) / 2;

                var found = FindSubstring(mid, s);
                if (found != null)
                {
                    longestSubstring = found;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return longestSubstring;
        }

        private string FindSubstring(int subLen, string s)
        {
            var hash = Hash(s.Substring(0, subLen));

            var set = new HashSet<long> {
            hash
        };

            var pow = 1L;
            for (var i = 1; i < subLen; i++)
                pow *= 31;

            var n = s.Length;
            for (var i = 0; i < n - subLen; ++i)
            { //O(n)
                hash = NextHash(pow, hash, s[i], s[i + subLen]);
                if (!set.Add(hash))
                    return s.Substring(i + 1, subLen);
            }

            return null;
        }

        private long Hash(string s)
        {
            var h = 0L;
            var a = 1L;

            var n = s.Length;
            for (var k = n; k >= 1; k--)
            {
                var ch = s[k - 1];
                h += (ch - 'a' + 1) * a;
                a *= 31;
            }

            return h;
        }

        private long NextHash(long pow, long hash, char left, char right)
        {
            return (hash - (left - 'a' + 1) * pow) * 31 + (right - 'a' + 1);
        }
    }
}
