using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int ArrangeCoins(int n)
        {
            int curRow = 1;
            long maxNum = 0;

            do
            {
                maxNum = curRow + maxNum;
                curRow++;
            }
            while (maxNum < n);

            return !IsLastRowFull(n, maxNum) ? curRow - 2 : curRow - 1;
        }

        private static bool IsLastRowFull(int n, long maxNum)
        {
            return (maxNum == n);
        }

        public int BinarySearch(int n)
        {
            long left = 0, right = n;
            long k, curr;
            while (left <= right)
            {
                k = left + (right - left) / 2;
                curr = k * (k + 1) / 2;

                if (curr == n) return (int)k;

                if (n < curr)
                {
                    right = k - 1;
                }
                else
                {
                    left = k + 1;
                }
            }
            return (int)right;
        }
    }
}
