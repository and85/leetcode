using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            
            var counts = arr1.GroupBy(a => a).ToDictionary(a => a.Key, a => a.Count());
            
            var uniqueSet = new HashSet<int>(arr2);
            var orderedNotPresent = arr1.Where(a => !uniqueSet.Contains(a)).OrderBy(a => a).ToList();

            int p = 0;
            foreach (int a2 in arr2)
            {
                
                int count = counts[a2];
                // implementation is based on counting sort. locate for each element as many slots as it appears in the initial array
                for (int i = 0; i < count; i++)
                {
                    arr1[i + p] = a2;
                }

                p += count;
            }

            foreach (int o in orderedNotPresent)
            {
                arr1[p] = o;
                p++;
            }

            return arr1;
        }
    }
}
