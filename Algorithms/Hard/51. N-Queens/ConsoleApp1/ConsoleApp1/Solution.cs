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
                // it's not required to check row because we always put one queen in one row
                // we can easily check if a column is already occupied
                var columns = new HashSet<int>();
                columns.Add(c);

                var diagonals = new HashSet<int>();
                diagonals.Add(GetDiagonal(0, c));
                diagonals.Add(GetAlternativeDiagonal(0, c));

                // start 0 row from putting a queen on position c
                for (int r = 1; r < n; r++)
                {
                    // 1. find the next visible position
                    // 2. if it's not possible to put a queen o the row, then backtrack to the previous row
                    // and move a queen on the next fisible position
                    // if it's possible to put a queen on the last row, t hen the current solution is included 
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
        private int GetDiagonal(int row, int column)
        {
            // the 
            return 0;
        }

        private int GetAlternativeDiagonal(int row, int column)
        {
            // the 
            return 0;
        }
    }
}
