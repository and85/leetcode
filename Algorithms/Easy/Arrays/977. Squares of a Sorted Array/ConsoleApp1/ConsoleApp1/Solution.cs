using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] SortedSquares(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
                A[i] = (int)Math.Pow(A[i], 2);

            Array.Sort(A);
            return A;
        }
    }
}
