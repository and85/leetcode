using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution_Attempt1
    {
        private char[][] _grid;
        private int _gridHeight;
        private int _gridWidth;
        private HashSet<Tuple<int, int>> _visitedCells;

        public int NumIslands(char[][] grid)
        {
            if (grid.Length == 0)
                return 0;

            _grid = grid;
            _gridHeight = grid.Length;
            _gridWidth = grid[0].Length;
            _visitedCells = new HashSet<Tuple<int, int>>();

            int result = 0;
            for (int r = 0; r < grid.Length; r++)
                for (int c = 0; c < _gridWidth; c++)
                {
                    var currCell = new Tuple<int, int>(r, c);
                    if (grid[r][c] == '1' && 
                        !_visitedCells.Contains(currCell))
                    {
                        result++;
                        ExploreIslandByDfs(currCell);
                    }
                }

            return result;
        }

        private void ExploreIslandByDfs(Tuple<int, int> currCell)
        {
            if (IsOutOfBorders(currCell) ||
                    _grid[currCell.Item1][currCell.Item2] == '0' ||
                    _visitedCells.Contains(currCell))
                return;

            _visitedCells.Add(currCell);
            ExploreIslandByDfs(new Tuple<int, int>(currCell.Item1 - 1, currCell.Item2));
            ExploreIslandByDfs(new Tuple<int, int>(currCell.Item1 + 1, currCell.Item2));
            ExploreIslandByDfs(new Tuple<int, int>(currCell.Item1, currCell.Item2 - 1));
            ExploreIslandByDfs(new Tuple<int, int>(currCell.Item1, currCell.Item2 + 1));
        }

        private bool IsOutOfBorders(Tuple<int, int> currCell)
        {
            return currCell.Item1 < 0 || 
                currCell.Item1 == _gridHeight ||
                currCell.Item2 < 0 || 
                currCell.Item2 == _gridWidth;
        }
    }
}
