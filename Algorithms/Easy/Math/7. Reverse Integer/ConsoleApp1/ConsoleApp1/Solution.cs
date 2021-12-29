using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Reverse(int x)
        {
            long res = 0;

            while (x != 0)
            {
                res = res * 10 + x % 10;
                x = x / 10;

                if (Math.Abs(res) > int.MaxValue)
                    return 0;
            }

            return (int)res;
        }

        public int Reverse_FirstAttempt(int x)
        {
            bool isNegative = (x < 0);
            if (isNegative)
            {
                x = -x;
            }

            int prevRevertedNumber = 0;
            int revertedNumber = 0;

            while (x != 0)
            {
                int curDigit = x % 10;

                revertedNumber = (revertedNumber * 10) + curDigit;

                if ((revertedNumber - curDigit) / 10 != prevRevertedNumber)
                {
                    return 0;
                }

                prevRevertedNumber = revertedNumber;
                x = x / 10;
            }

            return (isNegative) ? -revertedNumber : revertedNumber;
        }
    }
}
