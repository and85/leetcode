using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool RotateString(string A, string B)
        {
            if (A?.Length != B?.Length)
                return false;

            if (string.IsNullOrWhiteSpace(A) && string.IsNullOrWhiteSpace(B))
                return true;

            int i = A.Length - 1;
            int j = B.IndexOf(A[A.Length - 1]);

            if (j == -1)
                return false;

            while (i >= 0)
            {
                if (A[i] != B[j])
                    return false;
                i--;
                j--;

                if (j < 0)
                    j = B.Length - 1;
            }

            return true;
        }

    }
}
