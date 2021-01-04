using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int TwoCitySchedCost(int[][] costs)
        {
            Array.Sort(costs, new TotalCostComparer());

            int totalCost = 0;
            for (int i = 0; i < costs.Length; i ++)
            {
                if ( i < costs.Length / 2)
                    totalCost += costs[i][0];
                else
                    totalCost += costs[i][1];
            }

            return totalCost;
        }
    }

    public class TotalCostComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return (x[0] - x[1]).CompareTo(y[0] - y[1]);
        }
    }
}
