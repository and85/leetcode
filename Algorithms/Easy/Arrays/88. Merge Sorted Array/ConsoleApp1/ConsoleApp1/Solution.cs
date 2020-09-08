using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p = m + n - 1, i = m - 1, j = n - 1;
            
            while (i >= 0 || j >=0)
            {
                if (i < 0)
                    nums1[p--] = nums2[j--];
                else if (j < 0)
                    nums1[p--] = nums1[i--];
                else if (nums2[j] > nums1[i])
                    nums1[p--] = nums2[j--];
                else
                    nums1[p--] = nums1[i--];
            }
        }

        
    }
}
