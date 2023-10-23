using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            int num = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[r].Length; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        Dfs(grid, r, c);
                        num++;
                    }
                }
            }

            return num;
        }

        private void Dfs(char[][] grid, int r, int c)
        {
            grid[r][c] = '-';

            if (r + 1 < grid.Length && grid[r + 1][c] == '1')
            {
                Dfs(grid, r + 1, c);
            }
            
            if (r - 1 >= 0 && grid[r - 1][c] == '1')
            {
                Dfs(grid, r - 1, c);
            }

            if (c + 1 < grid[r].Length && grid[r][c + 1] == '1')
            {
                Dfs(grid, r, c + 1);
            }

            if (c - 1 >= 0 && grid[r][c - 1] == '1')
            {
                Dfs(grid, r, c - 1);
            }
        }
    }
}
