using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution_attempt1
    {
        public int MaxArea(int[] height)
        {
            //return BruteForce(height);
            return TwoPointers(height);
        }

        private int TwoPointers(int[] height)
        {
            int currArea = 0, maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                currArea = Square(height[left], height[right], right - left);
                maxArea = Math.Max(maxArea, currArea);

                if (height[left] <= height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }

        private int BruteForce(int[] height)
        {
            int maxArea = 0;
            int currArea = 0;
            for (int i = 0; i < height.Length; i++)
                for (int j = i + 1; j < height.Length; j++)
                {
                    currArea = Square(height[i], height[j], j - i);
                    if (currArea > maxArea)
                        maxArea = currArea;

                }

            return maxArea;
        }

        public int Square(int line1, int line2, int distance)
        {
            return Math.Min(line1, line2) * distance;
        }
    }
}
