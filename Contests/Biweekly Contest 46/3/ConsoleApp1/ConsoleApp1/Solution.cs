using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // 1765. Map of Highest Peak 
    public class Solution
    {
        public int[][] HighestPeak(int[][] isWater)
        {
            for (int r = 0; r < isWater.Length; r++)
                for (int c = 0; c < isWater.Length; c++)
                {
                    if (isWater[r][c] == 1)
                        isWater[r][c] = 0;
                    else
                        isWater[r][c] = 1;
                }

            for (int r = 0; r < isWater.Length; r++)
                for (int c = 0; c < isWater.Length; c++)
                {
                    if (isWater[r][c] == 0)
                        continue;

                    int min = FindMin(isWater, r, c);
                    isWater[r][c] = min + 1;
                }

            return isWater;
        }

        private int FindMin(int[][] isWater, int r, int c)
        {
            int min = int.MaxValue;

            if (r > 0 && isWater[r - 1][c] < min)
            {
                min = isWater[r - 1][c];
            }

            if (c > 0 && isWater[r][c - 1] < min)
            {
                min = isWater[r][c - 1];
            }

            if (r + 1 < isWater.Length - 1 && isWater[r + 1][c] < min)
            {
                min = isWater[r + 1][c];
            }

            if (c + 1 < isWater[0].Length - 1 && isWater[r][c + 1] < min)
            {
                min = isWater[r][c + 1];
            }

            return min < int.MaxValue ? min : 0;
        }
    }
}
