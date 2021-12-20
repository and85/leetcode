using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] SortedSquares(int[] nums)
        {
            //return Method1(nums);
            int[] res = new int[nums.Length];

            int l = 0, r = nums.Length - 1, s;

            for (int i = nums.Length - 1; i >=0; i--)
            {
                if (Math.Abs(nums[r]) > Math.Abs(nums[l]))
                {
                    res[i] = nums[r] * nums[r];
                    r--;
                }
                else
                {
                    res[i] = nums[l] * nums[l];
                    l++;
                }                
            }

            return res;
        }

        private int[] Method1(int[] nums)
        {
            int[] res = new int[nums.Length];
            int fn = FindFirstNonNegative(nums);

            int p = fn, n = p - 1;
            for (int r = 0; r < res.Length; r++)
            {
                if (n >= 0 && p < nums.Length)
                {
                    if (Math.Abs(nums[n]) > Math.Abs(nums[p]))
                    {
                        res[r] = nums[p] * nums[p];
                        p++;
                    }
                    else
                    if (Math.Abs(nums[n]) <= Math.Abs(nums[p]))
                    {
                        res[r] = nums[n] * nums[n];
                        n--;
                    }
                }
                else if (n < 0)
                {
                    res[r] = nums[p] * nums[p];
                    p++;
                }
                else
                {
                    res[r] = nums[n] * nums[n];
                    n--;
                }


            }

            return res;
        }

        private int FindFirstNonNegative(int[] nums)
        {
            int fn;
            for (fn = 0; fn < nums.Length; fn++)
            {
                if (nums[fn] < 0) continue;
                break;
            }
            
            return fn;
        }
    }
}
