using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int HeightChecker(int[] heights)
        {
            int[] correctHeights = new int[heights.Length];
            Array.Copy(heights, correctHeights, heights.Length);
            
            Array.Sort(correctHeights);

            int diff = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != correctHeights[i])
                    diff++;
            }

            return diff;
        }
    }
}
