using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class Solution
    {
        public bool IsToeplitzMatrix_Attempt1 (int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            for (int j = 0; j < matrix[0].Length; j++)
            if (i > 0 && j > 0 && matrix[i - 1][j - 1] != matrix[i][j])
                return false;
            return true;
        }

        public bool IsToeplitzMatrix(int[][] matrix)
        {

            for (int r = 0; r < matrix.Length; r++)
            for (int c = 0; c < matrix[r].Length; c++)
            {
                if (r > 0 && c > 0 && matrix[r - 1][c - 1] != matrix[r][c]) 
                    return false;
            }

            return true;
        }
    }
}
