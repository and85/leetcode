using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            Array.Sort(boxTypes, (int[] x, int[] y) => 
            { 
                return y[1].CompareTo(x[1]); 
            });

            int result = 0, boxes = truckSize;
            for (int i = 0; i < boxTypes.Length; i++)
            {
                if (boxes >= boxTypes[i][0])
                {
                    result += boxTypes[i][0] * boxTypes[i][1];
                    boxes -= boxTypes[i][0];
                }
                else
                {
                    result += boxes * boxTypes[i][1];
                    boxes = 0;
                }

                
                if (boxes == 0) break;
            }

            return result;
        }

        public class BoxComparer : IComparer<int[][]>
        {
            public int Compare(int[][] x, int[][] y)
            {
                return x[0][1].CompareTo(y[0][1]);
            }
        }
    }
}
