using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] AnagramMappings(int[] A, int[] B)
        {
            var dictB = new Dictionary<int, int>();
            for (int i = 0; i < B.Length; i++)
            {
                if (dictB.ContainsKey(B[i]))
                    continue;

                dictB.Add(B[i], i);
            }

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = dictB[A[i]];
            }

            return A;
        }
    }
}
