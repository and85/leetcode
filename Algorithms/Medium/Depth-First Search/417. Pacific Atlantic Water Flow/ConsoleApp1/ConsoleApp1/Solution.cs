using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        //private HashSet<(int, int)> _visitedCells;

        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            //_visitedCells = new HashSet<(int, int)>();

            var result = new List<IList<int>>();
            for (int r = 0; r < heights.Length; r++)
            for (int c = 0; c < heights[r].Length; c++)
            {
                var visitedCells = new HashSet<(int, int)>();
                if (CanReach(heights, r, c, visitedCells))
                    result.Add(new List<int>() { r, c });
            }

            return result;
        }

        private bool CanReach(int[][] heights, int r, int c, HashSet<(int, int)> visitedCells)
        {
            if (r < 0 || r >= heights.Length || c < 0 || c >= heights[r].Length)
                return false;

            bool pacific = r == 0 || c == 0;
            bool atlantic = c == heights[r].Length - 1 || r == heights.Length - 1;

            //if (_visitedCells.Contains((r, c)))
            //    return pacific && atlantic;
            
            visitedCells.Add((r, c));            

            if (pacific && atlantic) 
                return true;

            if (r + 1 < heights.Length && heights[r][c] >= heights[r + 1][c] && !visitedCells.Contains((r + 1, c)))
                return CanReach(heights, r + 1, c, visitedCells);
            
            if (r - 1 >= 0 && heights[r][c] >= heights[r - 1][c] && !visitedCells.Contains((r - 1, c)))
                return CanReach(heights, r - 1, c, visitedCells);

            if (c + 1 < heights[r].Length && heights[r][c] >= heights[r][c + 1] && !visitedCells.Contains((r, c + 1)))
                return CanReach(heights, r, c + 1, visitedCells);

            if (c - 1 >= 0 && heights[r][c] >= heights[r][c - 1] && !visitedCells.Contains((r, c - 1)))
                return CanReach(heights, r, c - 1, visitedCells);

            return false;
        }
    }
}
