using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] a)
        {
            int evenCounter = 0, temp;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    temp = a[evenCounter];
                    a[evenCounter] = a[i];
                    a[i] = temp;

                    evenCounter++;
                }
            }

            return a;
        }
    }
}
