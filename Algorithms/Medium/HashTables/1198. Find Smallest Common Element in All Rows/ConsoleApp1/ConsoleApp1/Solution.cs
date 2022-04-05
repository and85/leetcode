using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int SmallestCommonElement(int[][] mat)
        {

            var candidates = new HashSet<int>();
            for (int c = 0; c < mat[0].Length; c++)            
            {
                candidates.Add(mat[0][c]);
            }

            for (int r = 1; r < mat.Length; r++)
            {
                var notMatch = new HashSet<int>();
                foreach (var candidate in candidates)
                {
                    if (!IsCommon(candidate, mat[r]))
                    {
                        notMatch.Add(candidate);
                    }
                }

                foreach (var nm in notMatch)
                {
                    candidates.Remove(nm);
                }
            }

            int min = int.MaxValue;

            foreach (var candidate in candidates)
            {
                min = Math.Min(min, candidate);
            }

            return min < int.MaxValue ? min : -1;
        }

        private bool IsCommon(int candidate, int[] row)
        {
            int l = 0, r = row.Length - 1; 

            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (row[m] == candidate) return true;

                if (row[m] < candidate)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }

            return false;
        }
    }
}
