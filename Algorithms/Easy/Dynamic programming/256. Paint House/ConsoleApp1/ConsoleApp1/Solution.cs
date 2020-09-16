using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MinCost(int[][] costs)
        {
            for (int house = 0; house < costs.Length; house++)
            {
                // red, blue or green
                int redCost = costs[house][0];
                int blueCost = costs[house][1];
                int greenCost = costs[house][2];
            }

            return 0;
        }

        private int GetMinPrice()
        {
            throw new NotImplementedException();
        }
    }
}
