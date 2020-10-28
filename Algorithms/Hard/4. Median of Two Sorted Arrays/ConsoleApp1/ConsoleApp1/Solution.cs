using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums3 = new int[nums1.Length + nums2.Length];
            int p1 = 0, p2 = 0, min;

            for (int p3 = 0; p3 < nums3.Length; p3++)
            {
                if (p1 == nums1.Length)
                {
                    min = nums2[p2];
                    p2++;
                }
                else if (p2 == nums2.Length)
                {
                    min = nums1[p1];
                    p1++;
                }
                else if (nums1[p1] <= nums2[p2])
                {
                    min = nums1[p1];
                    p1++;
                }
                else
                {
                    min = nums2[p2];
                    p2++;
                }

                nums3[p3] = min;
            }

            if (nums3.Length == 1)
                return nums3[0];

            if (nums3.Length % 2 == 0)
            {
                int i1 = nums3.Length / 2;
                int i2 = nums3.Length / 2 - 1;
                return (nums3[i1] + nums3[i2]) / 2.0;
            }
            else
            {
                return nums3[nums3.Length / 2];
            }
        }
    }
}
