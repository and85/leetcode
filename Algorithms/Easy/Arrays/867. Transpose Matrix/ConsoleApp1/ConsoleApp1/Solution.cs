using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[][] Transpose(int[][] A)
        {
            int rowCount = A.Length;
            int colCount = A[0].Length;
            int[][] result = new int[colCount][];


            for (int c = 0; c < colCount; c++)
                result[c] = new int[rowCount];

            for (int r = 0; r < A.Length; r++)
            {
                for (int c = 0; c < A[r].Length; c++)
                {
                    result[c][r] = A[r][c];
                }
            }

            return result;
        }
    }
}
