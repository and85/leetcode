using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            int n = 10;
            var results = new List<string>();

            if (s.Length <= n)
                return results;
            
            var uniqueSubstrings = new HashSet<string>();
            string substring = s.Substring(0, n);
            uniqueSubstrings.Add(substring);

            // O(N)
            for (int i = 0; i < s.Length - n; i++)
            {
                int substringEndPosition = i + n;
                // get a new substring in O(1) by removing 1 character and adding the
                // next character from s, like in  Karp-Rabin algorithm
                substring = substring.Substring(1, n - 1) + s[substringEndPosition];

                if (!uniqueSubstrings.Contains(substring))
                {
                    uniqueSubstrings.Add(substring);
                }
                else
                {
                    if (!results.Contains(substring))
                        results.Add(substring);
                }
            }

            //uniqueSubstrings.To
            return results;
        }
    }
}
