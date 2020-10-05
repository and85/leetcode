using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int lastIndex = digits.Length - 1;
            int carry = (digits[lastIndex] + 1) / 10;
            int prevCarry = carry;
            digits[lastIndex] = (digits[lastIndex] + 1) % 10;

            for (int i = digits.Length - 2; i >= 0; i--)
            {
                carry = (digits[i] + prevCarry) / 10;
                digits[i] = (digits[i] + prevCarry) % 10;
                prevCarry = carry;
            }

            if (carry == 0)
                return digits;
            else
            {
                int[] newDigits = new int[digits.Length + 1];
                newDigits[0] = carry;
                Array.Copy(digits, 0, newDigits, 1, digits.Length);
                return newDigits;
            }
        }
    }
}
