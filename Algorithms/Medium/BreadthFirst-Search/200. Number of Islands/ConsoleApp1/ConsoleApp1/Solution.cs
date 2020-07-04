using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            int islandCounter = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j ++)
                {
                    if (IsNewIsland(grid, i, j))
                        islandCounter++;
                }

                Console.WriteLine();
            }

            return islandCounter;
        }

        private bool IsNewIsland(char[][] grid, int i, int j)
        {
            if (grid[i][j] == '1')
            {
                if (i == 0 && j == 0)
                    return true;
                else if ( i == 0 )
                {
                    if (grid[i][j - 1] == '0')
                        return true;
                }
                else if (j == 0)
                {
                    if (grid[i - 1][j] == '0')
                        return !IsNeighbourExistingIsland(grid, i, j);
                }
                else if ((grid[i - 1][j] == '0') && (grid[i][j - 1] == '0'))
                    return true;
            }

            return false;
        }

        private bool IsNeighbourExistingIsland(char[][] grid, int i, int j)
        {
            if (j + 1 < grid[i].Length)
            {
                if (grid[i][j + 1] == '1' && grid[i - 1][j + 1] == '1')
                    return true;
            }

            return false;
        }
    }
}
