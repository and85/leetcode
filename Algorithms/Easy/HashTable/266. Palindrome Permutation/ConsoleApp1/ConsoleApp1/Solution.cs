using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool CanPermutePalindrome(string s)
        {
            var entries = s.ToCharArray()
                .GroupBy(c => c)
                .ToDictionary(c => c.Key, c => c.Count());

            bool isOddLenght = IsOddNumber(s.Length);
            return CanPermutePalindrome(entries, isOddLenght);
        }

        private static bool IsOddNumber(int number)
        {
            return (number % 2) == 1;
        }

        private bool CanPermutePalindrome(Dictionary<char, int> entries, bool isOddLenght)
        {
            var oddEntries = entries.Where(e => IsOddNumber(e.Value));

            return isOddLenght ? 
                oddEntries.Count() == 1 : 
                oddEntries.Count() == 0;

        }
    }
}
