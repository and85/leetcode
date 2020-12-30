using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int i = 0, maxprofit = 0, valley, peak;
            while (i < prices.Length - 1)
            {
                valley = GetValley(prices, ref i);
                peak = GetPeak(prices, ref i);

                maxprofit += peak - valley;
            }
            return maxprofit;
        }

        private int GetPeak(int[] prices, ref int i)
        {
            int peak;
            while (i < prices.Length - 1 && IsAscending(prices, i))
                i++;
            peak = prices[i];
            return peak;
        }

        private int GetValley(int[] prices, ref int i)
        {
            int valley;
            while (i < prices.Length - 1 && IsDescending(prices, i))
                i++;
            valley = prices[i];
            return valley;
        }

        private bool IsAscending(int[] prices, int i)
        {
            return prices[i] <= prices[i + 1];
        }

        private bool IsDescending(int[] prices, int i)
        {
            return prices[i] >= prices[i + 1];
        }
    }
}
