using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] ReplaceElements(int[] arr)
        {
            int maxSeen = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = maxSeen;
                maxSeen = Math.Max(maxSeen, temp);
            }

            return arr;
        }
    }
}
