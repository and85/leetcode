using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            // implementation of Belman-Ford Algorithm
            // https://www.youtube.com/watch?v=FtN3BYH2Zes  
            // run relaxation of each vertex exactly n - 1 times
            // source vertex should have 0 cost to visit, all other vertexes should start from infinity cost
            var costs = new Dictionary<int, double>();
            for (int i = 1; i <= n; i++)
                costs[i] = double.PositiveInfinity;
            costs[k] = 0;

            int u, v, w;

            for (int i = 0; i < n - 1; i++)
            {
                bool isRelaxed = false;
                for (int t = 0; t < times.Length; t++)
                {
                    u = times[t][0];
                    v = times[t][1];
                    w = times[t][2];

                    double candidateCost = costs[u] + w;
                    if (costs[v] > candidateCost)
                    {
                        costs[v] = candidateCost;
                        isRelaxed = true;
                    }
                }

                if (!isRelaxed) 
                    break;
            }

            double maxCost = costs.Values.Max();
            return (maxCost < double.PositiveInfinity) ? (int)maxCost : -1;
        }
    }
}
