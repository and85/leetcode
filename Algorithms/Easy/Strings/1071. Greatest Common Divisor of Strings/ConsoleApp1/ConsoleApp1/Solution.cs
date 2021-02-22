using System;

namespace ConsoleApp1
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            if (str1.Equals(str2))
                return str1;

            string res; 
            if (str1.Length > str2.Length)
                res = FindGcd(str2, str1);
            else
                res = FindGcd(str1 , str2);

            return res;
        }

        private string FindGcd(string shortStr, string longStr)
        {
            for (int i = 0; i < shortStr.Length; i++)
            {
                string candidate = shortStr.Substring(0, shortStr.Length - i);

                if (IsSubstring(shortStr, longStr, candidate)) return candidate;
            }

            return string.Empty;
        }

        private bool IsSubstring(string shortStr, string longStr, string candidate)
        {
            if (shortStr.Length % candidate.Length != 0 || longStr.Length % candidate.Length != 0)
                return false;

            for (int i = 0; i < shortStr.Length / candidate.Length; i++)
            {
                string s = shortStr.Substring(i * candidate.Length, candidate.Length);
                if (!s.Equals(candidate))
                    return false;
            }

            for (int i = 0; i < longStr.Length / candidate.Length; i++)
            {
                string s = longStr.Substring(i * candidate.Length, candidate.Length);
                if (!s.Equals(candidate))
                    return false;
            }

            return true;
            
        }
    }
}
