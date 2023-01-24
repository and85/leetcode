using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {

        /*
        0 1 0 0
        0 0 0 1
        1 0 0 0
        0 0 1 0
        */

        public IList<IList<string>> SolveNQueens(int n)
        {            
            var result = new List<IList<string>>();

            for (int c = 0; c < n; c++)
            {
                int lastAddedColumn = -1, lastAddedSumDiagonal = -1, lastAddedDiffDiagonal = -1; ;

                // it's not required to check row because we always put one queen in one row
                // we can easily check if a column is already occupied
                var columns = new HashSet<int>();
                lastAddedColumn = c;
                columns.Add(c);

                // the two elements of the matrix are on the same diagonal only if the sum of the indices
                // or the difference of the indices of the elements are equal
                var diagonals = new HashSet<int>();
                lastAddedSumDiagonal = GetSumDiagonal(0, c);
                diagonals.Add(lastAddedSumDiagonal);
                lastAddedDiffDiagonal = GetDiffDiagonal(0, c);
                diagonals.Add(lastAddedDiffDiagonal);

                // start 0 row from putting a queen on position c
                for (int r = 1; r < n; r++)
                {
                    // 1. find the next visible position
                    bool nextPositionFound = false;
                    for (int f = lastAddedColumn + 1; f < n; f++)
                    {
                        if (columns.Contains(f)) continue;
                        
                        var d1 = GetSumDiagonal(r, f);
                        var d2 = GetDiffDiagonal(r, f);
                        if (diagonals.Contains(d1) || diagonals.Contains(d2)) continue;

                        lastAddedColumn = f;
                        lastAddedSumDiagonal = d1;
                        lastAddedDiffDiagonal = d2;

                        columns.Add(f);
                        diagonals.Add(d1);
                        diagonals.Add(d2);
                        nextPositionFound = true;
                        break;
                    }

                    // 2. if it's not possible to put a queen on the row, then backtrack to the previous row
                    // and move a queen on the next fisible position
                    if (!nextPositionFound)
                    {
                        diagonals.Remove(lastAddedSumDiagonal);
                        diagonals.Remove(lastAddedDiffDiagonal);
                        columns.Remove(lastAddedColumn);
                        r--;
                    }
                    
                    
                    // 3. if it's possible to put a queen on the last row, then the current solution is included 
                    // into the total solution
                }
            }

            return result;
        }


        /*
        0 1 0 0
        0 0 0 1
        1 0 0 0
        0 0 1 0
        */
        private int GetSumDiagonal(int row, int column)
        {
            // the 
            return row + column;
        }

        private int GetDiffDiagonal(int row, int column)
        {
            return row - column;
        }
    }
}
