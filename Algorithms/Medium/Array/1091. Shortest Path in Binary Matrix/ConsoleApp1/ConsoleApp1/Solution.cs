using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private int[][] _directions = new int[][]
        {
            new int[] { 0, -1 },
            new int[] { 1, -1 },
            new int[] { 1, 0 },
            new int[] { 1, 1 },
            new int[] { 0, 1 },
            new int[] { -1, 1 },
            new int[] { -1, 0 },
            new int[] { -1, -1 }
        };

        public int ShortestPathBinaryMatrix(int[][] grid)
        {

            return FindShortestPath(grid, 0);
        }

        private int FindShortestPath(int[][] grid, int curPos)
        {
            throw new NotImplementedException();
        }
    }
}
