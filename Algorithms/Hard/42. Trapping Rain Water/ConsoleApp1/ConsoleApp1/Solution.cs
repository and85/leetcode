using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            int left = FindFirsStone(height);
            if (left == -1)
                return 0;
            
            int right = left;

            int totalSum = 0, candidateSum = 0;

            // move from left to right end
            while (++right < height.Length)
                CalculateSum(height, ref left, right, ref totalSum, ref candidateSum);

            // move from right end to left pointer
            if (candidateSum > 0)
            {
                candidateSum = 0;
                int lastTallest = left;
                right = FindLastStone(height);
                left = right;

                while (--left >= lastTallest)
                {
                    CalculateSum(height, ref right, left, ref totalSum, ref candidateSum);
                }
            }

            return totalSum;
        }

        private void CalculateSum(int[] height, ref int p1, int p2, ref int totalSum, ref int candidateSum)
        {
            if (height[p2] >= height[p1])
            {
                totalSum += candidateSum;
                candidateSum = 0;
                p1 = p2;
            }
            else
            {
                candidateSum += height[p1] - height[p2];
            }
        }

        private int FindFirsStone(int[] height)
        {
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 0)
                    return i;
            }

            return -1;
        }

        private int FindLastStone(int[] height)
        {
            for (int i = height.Length - 1; i < height.Length; i--)
            {
                if (height[i] > 0)
                    return i;
            }

            return -1;
        }
    }
}
