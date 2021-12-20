using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // my solution, doesn't really consider how to handle hash overflow
    public class Solution
    {

        // https://leetcode.com/problems/implement-strstr/discuss/901302/C-Both-RabinKarp-Approach-O(N%2BL)-%2B-Naive-Slower-approach-Time-O((N-L)*L) 
        public int StrStr(string haystack, string needle)
        {
            int nLen = needle.Length, hLen = haystack.Length;
            if (nLen <= 0) return 0;
            if (hLen < nLen) return -1;
            var mod = 1009;     // PrimeNo can also use something like Math.Powr(2,31);
            int baseVal = 26;   // as its given in problem only small case letters r present, else use 256 for Full ASCII Set
            int H = 1;            // Raise by
                                  // newRollHash = (base*(prvRollHash-1stCharInWin*H)+newChar)%mod;

            // calculate initial hashValue
            int hHash = 0, nHash = 0, i = 0;
            for (i = 0; i < nLen; i++)
            {
                hHash = ((hHash * baseVal) + haystack[i]) % mod;
                nHash = ((nHash * baseVal) + needle[i]) % mod;
                if (i < nLen - 1) H = (H * baseVal) % mod;     // one less as for needle of length 3 we only want the base^2 thats multiple H with base just twice
            }

            for (i = 0; i < hLen - nLen + 1; i++)
            {
                if (hHash == nHash)
                {
                    int k = 0;
                    while (k < nLen && haystack[k + i] == needle[k])
                        k++;
                    if (k == nLen) return i;
                }
                // calculate next rolling Hash
                if (i < hLen - nLen)
                    hHash = (baseVal * (hHash - (haystack[i] * H)) + haystack[i + nLen]) % mod;

                if (hHash < 0) hHash += mod;
            }
            return -1;
        }

        public int MyStrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) return 0;

            if (haystack.Length < needle.Length) return -1;

            long nh = GetHash(needle);
            string s = haystack.Substring(0, needle.Length);
            long h = GetHash(s);

            if (nh == h && CompareStrings(needle, s))
                return 0;

            for (int i = 1; i < haystack.Length - needle.Length + 1; i++)
            {
                h = GetRollingHash(haystack[i - 1], haystack[i + needle.Length - 1], h, needle.Length);

                if (h == nh && CompareStrings(needle, haystack.Substring(i, needle.Length)))
                    return i;
            }

            return -1;
        }

        private bool CompareStrings(string needle, string s)
        {
            return needle.Equals(s);
        }

        private long GetRollingHash(char removedSymbol, char addedSymbol, long oldHash, int length)
        {
            // ABC
            // A*31^2 + B*31 + C
            long r = (removedSymbol - 'a') * (long)Math.Pow(31, length - 1);
            return (oldHash - r) * 31 + (addedSymbol - 'a');
        }

        private long GetHash(string s)
        {
            long hash = 0;
            int p = s.Length - 1;
            foreach (char c in s)
                hash += (c - 'a') * (long)Math.Pow(31, p--);

            return hash;
        }
    }
}
