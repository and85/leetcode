using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                (s[left], s[right]) = (s[right--], s[left++]);
            }
        }
    }
}
