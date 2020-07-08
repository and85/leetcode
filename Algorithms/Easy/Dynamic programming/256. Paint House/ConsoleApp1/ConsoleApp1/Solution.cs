using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MinCost(int[][] costs)
        {
            // TODO: this problem is partially similar to house rober
            int priceCandidate = int.MaxValue;

            for (int i = 1; i < costs.Length; i++)
            {
                int price = GetMinPrice(costs[i - 1], );
                if (priceCandidate > price)
                    priceCandidate = price;
            }

            return priceCandidate;
        }

        private int GetMinPrice()
        {
            throw new NotImplementedException();
        }
    }
}
