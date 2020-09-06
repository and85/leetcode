using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsArmstrong(int N)
        {
            int sum = 0;
            string str = N.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                int integer = Convert.ToInt32(str[i].ToString());
                sum += (int)Math.Pow(integer, str.Length);
            }

            return sum == N;
        }
    }
}
