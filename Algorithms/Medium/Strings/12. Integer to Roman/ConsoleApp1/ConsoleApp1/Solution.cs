using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // https://leetcode.com/problems/integer-to-roman/
    /*
    Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, two is written as II in Roman numeral, just two one's added together. Twelve is written as, XII, which is simply X + II. The number twenty seven is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given an integer, convert it to a roman numeral. Input is guaranteed to be within the range from 1 to 3999.

Example 1:

Input: 3
Output: "III"
Example 2:

Input: 4
Output: "IV"
Example 3:

Input: 9
Output: "IX"
Example 4:

Input: 58
Output: "LVIII"
Explanation: L = 50, V = 5, III = 3.
Example 5:

Input: 1994
Output: "MCMXCIV"
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
    */
    public class Solution
    {
        private Dictionary<int, string> _digits = new Dictionary<int, string>()
        {
            {1, "I" },
            {4, "IV" },
            {5, "V" },
            {9, "IX" },
            {10, "X" },
            {40, "XL" },
            {50, "L" },
            {90, "XC" },
            {100, "C" },
            {400, "CD" },
            {500, "D" },
            {900, "CM" },
            {1000, "M" },
        };

        private int FindMaxDigit(int num)
        {
            // O(N) we could optimise this part using binary search
            if (num >= 1000) return 1000;
            if (num >= 900) return 900;
            if (num >= 500) return 500;
            if (num >= 400) return 400;
            if (num >= 100) return 100;
            if (num >= 90) return 90;
            if (num >= 50) return 50;
            if (num >= 40) return 40;
            if (num >= 10) return 10;
            if (num >= 9) return 9;
            if (num >= 5) return 5;
            if (num >= 4) return 4;
            if (num >= 1) return 1;

            return 0;
        }

        public string IntToRoman(int num)
        {
            int remainder = num;
            int maxDigit;
            //StringBuilder result = new StringBuilder(); 
            string result = string.Empty;
            while (remainder != 0)
            {
                maxDigit = FindMaxDigit(remainder);
                for (int i = 0; i < remainder / maxDigit; i++)
                    result += _digits[maxDigit];

                remainder %= maxDigit;
            }

            return result.ToString();
        }
    }
}
