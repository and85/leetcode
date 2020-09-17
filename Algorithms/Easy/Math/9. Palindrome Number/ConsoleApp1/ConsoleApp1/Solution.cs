using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            string originalString = x.ToString();
            char[] digits = originalString.ToCharArray();
            Array.Reverse(digits);
            string reversedString = new string(digits);

            return originalString.Equals(reversedString);
        }
    }
}
