﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            //if (x < 0)
            //    return false;

            //string originalString = x.ToString();
            //char[] digits = originalString.ToCharArray();
            //Array.Reverse(digits);
            //string reversedString = new string(digits);

            //return originalString.Equals(reversedString);

            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
