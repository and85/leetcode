using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private int _height;
        private int _width;
        private int[][] _grid;

        public int FindCircleNum(int[][] M)
        {
            _height = M.Length;
            _width = M[0].Length;
            _grid = M;

            int circles = 0;
            for (int r = 0; r < _height; r++)
            for (int c = 0; c < _width; c++)
            {
                if (_grid[r][c] == 1)
                {
                    Dfs(r, c);
                    circles++;
                }
            }

            return circles;
        }

        private void Dfs(int r, int c)
        {
            _grid[r][c] = -1;

            for (int i = 0; i < _width; i++)
            {
                if (_grid[r][i] == 1)
                {
                    _grid[r][i] = -1;
                    Dfs(i, i);
                }
            }
        }
    }
}
