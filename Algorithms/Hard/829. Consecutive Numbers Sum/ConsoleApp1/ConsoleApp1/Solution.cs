using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int ConsecutiveNumbersSum(int n)
        {
            return DynamicProgramming(n);
        }

        private static int DynamicProgramming(int n)
        {
            int result = 1;
            int curNum, newSum;

            var dpPrevRow = new int[n];
            dpPrevRow[0] = 1;
            var dpCurRow = new int[n];
            bool foundRow;

            // first and last rows are not required
            for (int r = 1; r < n - 1; r++)
            {
                foundRow = false;
                for (int c = 0; c <= r; c++)
                {
                    curNum = r + 1;
                    newSum = curNum + dpPrevRow[c];
                    if (newSum <= n)
                        dpCurRow[c] = curNum + dpPrevRow[c];

                    if (newSum == n && !foundRow && r != c && dpPrevRow[c] > 0)
                    {
                        result++;
                        foundRow = true;
                    }
                }
                dpPrevRow = dpCurRow;
            }

            //PrintMatrix(dp, n);

            return result;
        }

        //private void PrintMatrix(int[,] matrix, int n)
        //{
        //    for (int r = 0; r < n; r++)
        //    {
        //        for (int c = 0; c < n; c++)
        //        {
        //            string padding = string.Empty;
        //            if (matrix[r, c] < 10)
        //                padding = " ";
        //            Console.Write(padding + matrix[r, c] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
