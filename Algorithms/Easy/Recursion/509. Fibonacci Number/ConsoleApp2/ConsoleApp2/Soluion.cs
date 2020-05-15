using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Solution
    {
        public int Fib(int N)
        {
            if (N <= 1)
                return N;

            int prev = 0;
            int sum = 1;
           
            int temp;

            for (int i = 2; i <= N; i++)
            {
                temp = prev; 
                prev = sum; 
                sum = temp + sum; 
             }

            return sum;
        }
    }
}
