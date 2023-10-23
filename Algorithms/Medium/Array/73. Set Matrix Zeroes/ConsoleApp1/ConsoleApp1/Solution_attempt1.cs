using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            /*
                0 1 2 0       0 0 0 0
                3 4 5 2       0 4 5 0
                1 3 1 5       0 3 1 0

                O (m + n) - > store rows and columns which contain zeros
            */
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();
            for (int r = 0; r < matrix.Length; r++)
            for (int c = 0; c < matrix[r].Length; c++)
            {
                if (matrix[r][c] == 0)
                {
                    rows.Add(r);
                    cols.Add(c);
                }
            }

            foreach (var r in rows)
                SetRow(matrix, r);

            foreach (var c in cols)
                SetColumn(matrix, c);
        }

        private void SetRow(int[][] matrix, int r)
        {
            for (int c = 0; c < matrix[r].Length; c++)
                matrix[r][c] = 0;
        }

        private void SetColumn(int[][] matrix, int c)
        {
            for (int r = 0; r < matrix.Length; r++)
                matrix[r][c] = 0;
        }
    }
}
