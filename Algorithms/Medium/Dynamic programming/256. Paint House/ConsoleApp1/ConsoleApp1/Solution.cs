using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MinCost(int[][] costs)
        {
            if (costs.Length == 0)
                return 0;

            int lastColorIndex = 2;

            for (int house = 1; house < costs.Length; house++)
            {
                int prevHouse = house - 1;
                for (int currColor = 0; currColor <= lastColorIndex; currColor++)
                {
                    int prevMinCost = int.MaxValue;
                    for (int prevColor = 0; prevColor <= lastColorIndex; prevColor++)
                    {
                        if (prevColor == currColor)
                            continue;

                        if (costs[prevHouse][prevColor] < prevMinCost)
                            prevMinCost = costs[prevHouse][prevColor];
                    }

                    costs[house][currColor] += prevMinCost;
                }
            }

            int lastHouseIndex = costs.Length - 1;
            return costs[lastHouseIndex].Min();
        }
    }
}
