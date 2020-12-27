using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var result = new List<int>();
            if (s.Length < p.Length)
                return result;

            var htS = new int[26];
            var htP = new int[26];
            foreach (char c in p)
                htP[c - 97]++;

            for (int i = 0; i < p.Length - 1; i++)
                htS[s[i] - 97]++;

            char ch;            
            for (int i = 0; i <= s.Length - p.Length; i++)
            {
                ch = s[p.Length - 1 + i];                
                htS[ch - 97]++;                

                if (IsAnagram(htS, htP))
                    result.Add(i);

                htS[s[i] - 97]--;
            }

            return result;
        }

        private bool IsAnagram(int[] htS, int[] htP)
        {
            // or it could be: return Enumerable.SequenceEqual(htS, htP);
            for (int i = 0; i < 26; i++)
            {
                if (htS[i] != htP[i])
                    return false;
            }

            return true;
        }
    }
}
