using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int FindNumbers(int[] nums)
        {
            int res = 0;

            foreach (int num in nums)
                res += (GetDigitNumber(num) % 2 == 0) ? 1 : 0;

            return res;
        }

        private int GetDigitNumber(int num)
        {
            int res = 1;
            while (num / 10 > 0)
            {
                num = num / 10;
                res++;
            }

            return res;
        }
    }
}
