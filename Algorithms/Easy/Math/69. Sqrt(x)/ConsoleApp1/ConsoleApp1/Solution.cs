using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            if (x <= 1)
                return x;

            decimal dx = x;

            decimal median = (int)(x / 2);

            while (median >= 1)
            {
                if (median * median == dx)
                    return (int)median;

                if (median * median < dx)
                    for (decimal i = median; i <= dx; i++)
                    {

                        if (i * i > dx)
                            return (int)(i % 1 == 0 ? i - 1 : i);
                    }

                median = median / 2;
            }

            return 0;
        }
    }
}
