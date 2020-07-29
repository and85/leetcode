using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            float precision = 0.1f;
            float min = 0;
            float max = x;
            float median = 0;
            while (max - min > precision)
            {
                median = (min + max) / 2;

                if (median * median == x)
                    return GetResult(x, median);

                if ((median * median) >= x)
                {
                    max = median;
                }
                else
                {
                    min = median;
                }
            }

            return GetResult(x, median);
        }

        private static int GetResult(int x, float median)
        {
            int result = (int)Math.Round(median);
            try
            {
                if (checked(result * result) > x)
                    result -= 1;
            }
            catch (OverflowException)
            {
                result -= 1;
            }    
            
            return result;
        }
    }
}
