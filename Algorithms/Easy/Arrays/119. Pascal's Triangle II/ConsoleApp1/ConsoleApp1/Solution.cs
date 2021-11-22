using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            int[] prev = new int[rowIndex + 1];
            int[] res = new int[rowIndex + 1];
            res[0] = 1;
            for (int r = 0; r <= rowIndex; r++)
            {
                res[r] = 1;

                for (int c = 1; c < r; c++)
                {
                    res[c] = prev[c - 1] + prev[c];
                }

                Array.Copy(res, prev, r + 1);
            }
            
            return res.ToList();
        }
    }
}
