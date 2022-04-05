using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool RotateString_firstattempt(string a, string b)
        {
            if (a?.Length != b?.Length)
                return false;

            if (string.IsNullOrWhiteSpace(a) && string.IsNullOrWhiteSpace(b))
                return true;

            var sb = new StringBuilder(a);
            char fc;
            for (int i = 0; i < a.Length; i++)
            {
                fc = sb[0];                
                sb.Remove(0, 1);
                sb.Append(fc);

                if (sb.Equals(b))
                    return true;
            }

            return false;
        }

        const int Prime = 31;

        public bool RotateString(string s, string goal)
        {            
            //return s.Length == goal.Length && (s + s).Contains(goal);
            //return s.Length =   = goal.Length && RabinKarp_Overflow(s + s, goal);
            return s.Length == goal.Length && RabinKarp(goal, s + s, Prime);
        }

        private bool RabinKarp_Overflow(string str, string pattern)
        {
            int patternHash = GetHash(pattern);
            string s = str.Substring(0, pattern.Length);
            int newHash = GetHash(s);

            for (int i = pattern.Length; i < str.Length; i++)
            {
                newHash = GetRollingHash(newHash, str, i);

                if (newHash == patternHash && str.Substring(i - pattern.Length + 1, pattern.Length) == pattern)
                    return true;
            }


            return false;
        }

        private int GetRollingHash(int oldHash, string str, int i)
        {
            int m = str.Length / 2;
            int x = oldHash - (str[i - m] - 'a');
            x = x / Prime;

            int newHash = x + (str[i] - 'a') * (int)Math.Pow(Prime, m - 1);

            return newHash;// % m;
        }

        private int GetHash(string pattern)
        {
            
            int p = 0;
            int hash = 0;
            foreach (var c in pattern)
            {
                hash += (c - 'a') * (int)Math.Pow(Prime, p++);
            }

            return hash;// % pattern.Length;
        }

        // d is the number of characters in the input alphabet
        public readonly static int d = 256;

        /* pat -> pattern
            txt -> text
            q -> A prime number
        */
        public bool RabinKarp(String pattern, String str, int q)
        {
            int m = pattern.Length;
            int n = str.Length;
            int i, j;
            int patternHash = 0; // hash value for pattern
            int substringHash = 0; // hash value for txt
            int h = 1;

            // The value of h would be "pow(d, M-1)%q"
            for (i = 0; i < m - 1; i++)
                h = (h * d) % q;

            // Calculate the hash value of pattern and first window of text
            for (i = 0; i < m; i++)
            {
                patternHash = (d * patternHash + pattern[i]) % q;
                substringHash = (d * substringHash + str[i]) % q;
            }

            // Slide the pattern over text one by one
            for (i = 0; i <= n - m; i++)
            {

                // Check the hash values of current window of text
                // and pattern. If the hash values match then only
                // check for characters one by one
                if (patternHash == substringHash)
                {
                    /* Check for characters one by one */
                    for (j = 0; j < m; j++)
                    {
                        if (str[i + j] != pattern[j])
                            break;
                    }

                    // if p == t and pat[0...M-1] = txt[i, i+1, ...i+M-1]
                    if (j == m)
                        //Console.WriteLine("Pattern found at index " + i);
                        return true;
                }

                // Calculate hash value for next window of text: Remove
                // leading digit, add trailing digit
                if (i < n - m)
                {
                    substringHash = (d * (substringHash - str[i] * h) + str[i + m]) % q;

                    // We might get negative value of t, converting it
                    // to positive
                    if (substringHash < 0)
                        substringHash = (substringHash + q);
                }
            }

            return false;
        }
    }
}
