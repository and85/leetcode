using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool IsStrobogrammatic(string num)
        {
            int i = 0, j = num.Length - 1;

            while (i <= j)
            {
                if ((num[i] == '6' && num[j] == '9') ||
                    (num[i] == '9' && num[j] == '6') ||
                    (num[i] == '8' && num[j] == '8') ||
                    (num[i] == '1' && num[j] == '1') ||
                    (num[i] == '0' && num[j] == '0')
                    )
                {
                    i++;
                    j--;
                    continue;
                }
                else
                    return false;
            }

            return true;
        }
    }
}
