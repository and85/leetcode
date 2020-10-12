using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsPerfectSquare(int num)
        {
            if (num <= 1)
                return true;

            double high = num, low = 0, median = 0, epsilon = 0.000001;
            while (high - low > epsilon)
            {
                median = (high - low) / 2 + low;

                if (median * median - num > 0)
                    high = median;
                else if (median * median - num < 0)
                    low = median;
                else if (median * median - num == 0)
                    return true;

            }

            return Round(median) * Round(median) == num;
            //return Math.Round(median) * Math.Round(median) == num;
        }

        private int Round(double num)
        {
            if (num - (int)(num) >= 0.5)
            {
                return (int)(num) + 1;
            }

            return (int)(num);
        }
    }
}
