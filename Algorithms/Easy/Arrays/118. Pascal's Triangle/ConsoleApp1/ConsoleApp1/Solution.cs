using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();
            int[] prevRow = null;
            for (int i = 0; i < numRows; i++)
            {
                var curRow = new List<int>();
                if (prevRow == null)
                {
                    curRow.Add(1);
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        int num = 0;
                        if (j - 1 < 0 || j >= prevRow.Length)
                            num = 1;
                        else
                            num = prevRow[j - 1] + prevRow[j];
                        curRow.Add(num);
                    }
                }

                prevRow = curRow.ToArray();
                result.Add(curRow);
            }

            return result;
        }
    }
}
