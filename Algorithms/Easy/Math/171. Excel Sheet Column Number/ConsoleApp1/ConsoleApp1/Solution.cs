using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int TitleToNumber(string s)
        {
            int result = 0;
            const int alphabetLenght = 26;
            char currDigit;
            int digitWeight;
            int digitValue;
            for (int i = 0; i < s.Length; i++)
            {
                currDigit = s[i];
                digitWeight = s.Length - i - 1;
                digitValue = (int)Math.Pow(alphabetLenght, digitWeight) * CurrentDigit(currDigit);

                result += digitValue;
            }

            return result;
        }

        private int CurrentDigit(char digit)
        {
            char start = 'A';
            return digit - start + 1; // A is 1, B is 2, etc.
        }
    }
}
