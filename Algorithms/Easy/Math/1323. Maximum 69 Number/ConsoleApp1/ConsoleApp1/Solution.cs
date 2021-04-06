using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Maximum69Number(int num)
        {
            char[] array = num.ToString().ToCharArray();
            int firstPosition = num.ToString().IndexOf('6');

            if (firstPosition == -1)
                return num;

            array[firstPosition] = '9';

            return Convert.ToInt32(new string(array));
        }
    }
}
