using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int CountNegatives(int[][] grid)
        {
            int counter = 0, index;

            for (int r = 0; r < grid.Length; r++)
            {
                index = BinarySearch(grid[r]);
                counter += grid[0].Length - index;
            }

            return counter;
        }
        
        private int BinarySearch(int[] row)
        {
            int low = 0;
            int high = row.Length - 1;

            while (low <= high)
            {
                int median = low + (high - low) / 2;	

                if (row[median] >= 0)
                {
                    low = median + 1;
                }
                else
                {
                    high = median - 1;
                }
            }

            return low;

        }
    }
}
