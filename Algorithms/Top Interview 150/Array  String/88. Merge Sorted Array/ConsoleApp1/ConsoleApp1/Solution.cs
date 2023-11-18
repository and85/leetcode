using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p = m + n - 1, i = m - 1, j = n - 1;

            while (i >= 0 || j >= 0)
            {
                if (i < 0)
                {
                    nums1[p--] = nums2[j--];
                }
                else if (j < 0)
                {
                    nums1[p--] = nums1[i--];
                }
                else if (nums2[j] > nums1[i])
                {
                    nums1[p--] = nums2[j--];
                }
                else
                {
                    nums1[p--] = nums1[i--];
                }
            }

        }

        public void Merge_ExtraSpace(int[] nums1, int m, int[] nums2, int n)
        {
            int[] result = new int[nums1.Length];

            if (n == 0) return;

            int i = 0, j = 0, w = 0;
            while(w < nums1.Length)
            {
                if (i >= m)
                {
                    result[w] = nums2[j];
                    j++;
                }
                else if (j >= n)
                {
                    result[w] = nums1[i];
                    i++;
                }
                else if (nums1[i] <= nums2[j])
                {
                    result[w] = nums1[i];
                    i++;
                }
                else
                {
                    result[w] = nums2[j];
                    j++;
                }                

                w++;
            }

            //nums1 = result;
            Array.Copy(result, nums1, nums1.Length);
        }
    }
}
