using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            int i = 0;
            int lastIndex = arr.Length - 1;
            while (i < lastIndex)
            {
                if (arr[i] == 0)
                {
                    Shift(arr, i + 1);
                    i++;
                }
                i++;
            }
        }

        private void Shift(int[] arr, int shiftStart)
        {
            int lastIndex = arr.Length - 1;
            for (int i = lastIndex - 1; i >= shiftStart; i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[shiftStart] = 0;
        }
    }
}
