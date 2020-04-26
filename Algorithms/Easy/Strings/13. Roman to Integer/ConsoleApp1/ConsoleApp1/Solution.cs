using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            var digits = GetDigits();
            int result = 0;
            int integerCandidate;
            string latinTwoSymbols;
            for (int i = 0; i < s.Length; i++)
            {
                integerCandidate = digits[s[i].ToString()];
                if (i + 1 != s.Length)
                {
                    latinTwoSymbols = s[i].ToString() + s[i + 1];
                    if (digits.ContainsKey(latinTwoSymbols))
                    {
                        integerCandidate = digits[latinTwoSymbols];
                        i++;
                    }
                }
                result += integerCandidate;
            }

            return result;
        }

        private Dictionary<string, int> GetDigits()
        {
            return new Dictionary<string, int>
            {
                { "I", 1 },
                { "V", 5 },
                { "X", 10 },
                { "L", 50 },
                { "C", 100 },
                { "D", 500 },
                { "M", 1000 },
                { "IV", 4 },
                { "IX", 9 },
                { "XL", 40 },
                { "XC", 90 },
                { "CD", 400 },
                { "CM", 900 }
            };
        }
    }
}
