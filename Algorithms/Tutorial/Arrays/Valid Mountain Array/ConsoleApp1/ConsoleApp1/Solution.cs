using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool ValidMountainArray(int[] a)
        {
            if (a.Length < 3)
                return false;

            bool isIncreasing = false;
            bool isDecreasing = false;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == a[i - 1])
                    return false;

                if (a[i] > a[i - 1])
                {
                    if (isDecreasing)
                        return false;

                    isIncreasing = true;
                }
                else
                {
                    if (!isIncreasing)
                        return false;

                    isDecreasing = true;
                }
            }

            return isIncreasing && isDecreasing;
        }
    }
}
