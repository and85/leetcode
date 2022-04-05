using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<string> FindRepeatedDnaSequences_FirstAttempt(string s)
        {
            int n = 10;
            //var results = new List<string>();

            if (s.Length <= n)
                return new List<string>();
            
            var uniqueSubstrings = new HashSet<string>();
            var results = new HashSet<string>();
            string substring = s.Substring(0, n);
            uniqueSubstrings.Add(substring);

            // O(N)
            for (int i = 0; i < s.Length - n; i++)
            {
                int substringEndPosition = i + n;
                // get a new substring in O(1) by removing 1 character and adding the
                // next character from s, like in  Karp-Rabin algorithm
                substring = substring.Substring(1, n - 1) + s[substringEndPosition];

                if (!uniqueSubstrings.TryGetValue(substring, out string _))
                {
                    uniqueSubstrings.Add(substring);
                }
                else
                {
                    results.Add(substring);
                }
            }

            return new List<string>(results);
        }

        public IList<string> FindRepeatedDnaSequences(string s)
        {
            var result = new List<string>();
            var dict = new Dictionary<string, int>();
            
            for (int i = 0; i <= s.Length - 10; i++)
            {
                string sub = s.Substring(i, 10);

                if (dict.ContainsKey(sub))
                {
                    dict[sub]++;
                }
                else
                {
                    dict.Add(sub, 1);
                }

            }

            foreach (var d in dict)
            {
                if (d.Value > 1)
                    result.Add(d.Key);
            }

            return result;
        }
    }
}
