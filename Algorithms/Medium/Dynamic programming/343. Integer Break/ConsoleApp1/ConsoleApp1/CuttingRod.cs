using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CuttingRod
    {

        public int maxValue(int[] price)
        {
            int[] max = new int[price.Length + 1];
            for (int i = 1; i <= price.Length; i++)
            {
                for (int j = i; j <= price.Length; j++)
                {
                    max[j] = Math.Max(max[j], max[j - i] + price[i - 1]);
                }
            }
            return max[price.Length];
        }

        public int maxValue1(int[] price)
        {
            int[] max = new int[price.Length + 1];
            for (int i = 1; i <= price.Length; i++)
            {
                max[i] = price[i - 1];
            }
            for (int i = 1; i <= price.Length; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    max[i] = Math.Max(max[i], max[i - j] + max[j]);
                }
            }
            return max[price.Length];
        }

        public int recursiveMaxValue(int[] price, int len)
        {
            if (len <= 0)
            {
                return 0;
            }
            int maxValue = 0;
            for (int i = 0; i < len; i++)
            {
                int val = price[i] + recursiveMaxValue(price, len - i - 1);
                if (maxValue < val)
                {
                    maxValue = val;
                }
            }
            return maxValue;
        }
    }
}