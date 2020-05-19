using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            int maxLength = Math.Max(num1.Length, num2.Length);

            char ascii0 = '0';
            char ascii1 = '1';
            char asci9 = '9';
            char prevDigit = ascii0;
            var resSB = new StringBuilder(maxLength);

            for (int i = 0; i < maxLength; i++)
            {
                char digit1 = (num1.Length > i) ? num1[num1.Length - 1 - i] : ascii0;
                char digit2 = (num2.Length > i) ? num2[num2.Length - 1 - i] : ascii0;

                int digitSum = digit1 + digit2 + prevDigit - 2*ascii0;
                if (digitSum > asci9)
                {
                    prevDigit = ascii1;
                    digitSum = digitSum - asci9 - ascii1 + 2*ascii0;
                }
                else
                    prevDigit = ascii0;

                resSB.Append(Convert.ToChar(digitSum));
            }

            if (prevDigit == ascii1)
                resSB.Append(Convert.ToChar(ascii1));

            char[] charArray = resSB.ToString().ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
