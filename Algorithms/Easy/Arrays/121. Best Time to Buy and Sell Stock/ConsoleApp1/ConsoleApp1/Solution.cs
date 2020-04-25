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
            if (prices.Length == 0)
                return 0;

            int maxProfit = 0;
            int minBuy = prices[0];
            int profit;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minBuy)
                    minBuy = prices[i];
                
                if (prices[i] > minBuy)
                {
                    profit = prices[i] - minBuy;
                    if (profit > maxProfit)
                        maxProfit = profit;
                }                   
            }

            return maxProfit;
        }
    }
}
