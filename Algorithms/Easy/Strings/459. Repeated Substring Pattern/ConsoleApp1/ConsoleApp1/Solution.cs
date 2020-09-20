using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool RepeatedSubstringPattern(string s)
        {
            if (s.Length < 2)
                return false;

            Stack<string> candidates = new Stack<string>();

            StringBuilder candidate = new StringBuilder();
            for (int i = 0; i < s.Length / 2; i++)
            {
                candidate.Append(s[i]);

                if (s.Substring(i + 1, s.Length - i - 1).StartsWith(candidate.ToString()))
                {
                    candidates.Push(candidate.ToString());
                }
            }

            while (candidates.Count != 0)
            {

                // if at least one candidate match return true
                string candidateStr = candidates.Pop();
                if (CheckCandidate(s, candidateStr))
                    return true;
            }

            return false;
        }

        private static bool CheckCandidate(string s, string candidateStr)
        {
            if (s.Length % candidateStr.Length != 0)
                return false;

            for (int i = candidateStr.Length * 2; i < s.Length; i += candidateStr.Length)
            {
                if (s.Substring(i, candidateStr.Length) != candidateStr)
                    return false;
            }

            return true;
        }
    }
}
