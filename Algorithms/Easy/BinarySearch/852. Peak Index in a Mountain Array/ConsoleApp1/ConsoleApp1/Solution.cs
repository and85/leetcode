using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        // l                   h 
        // 1 2 3 4 5 6 7 6 5 4 3
        
        public int PeakIndexInMountainArray(int[] arr)
        {
            int l = 0, h = arr.Length - 1, median = -1;

            while (l <= h)
            {
                median = l + (h - l) / 2;

                if (median == 0)
                    return h;

                if (arr[median] > arr[median - 1] && arr[median] > arr[median + 1])
                    break;                             

                if (arr[median] > arr[median - 1])
                {
                    l = median + 1;
                    continue;
                }
                else                
                {
                    h = median - 1;
                    continue;
                }

                
            }

            return median;
        }
    }
}
