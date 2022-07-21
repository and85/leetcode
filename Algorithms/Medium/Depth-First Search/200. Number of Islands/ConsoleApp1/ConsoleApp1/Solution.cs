using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private (int, int)[] _directions = new (int, int)[]
        {
            (1, 0),
            (-1, 0),
            (0, 1),
            (0, -1)
        };

        public int NumIslands(char[][] grid)
        {
            int islands = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[r].Length; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        Dfs(r, c, grid);
                        islands++;
                    }
                }
            }

            return islands;
        }

        private void Dfs(int r, int c, char[][] grid)
        {
            if (r < 0 || r == grid.Length || c < 0 || c == grid[0].Length || grid[r][c] == '0')
            {
                return;
            }
            
            grid[r][c] = '0';

            foreach (var d in _directions)
            {
                Dfs(r + d.Item1, c + d.Item2, grid);
            }
        }
    }
}
