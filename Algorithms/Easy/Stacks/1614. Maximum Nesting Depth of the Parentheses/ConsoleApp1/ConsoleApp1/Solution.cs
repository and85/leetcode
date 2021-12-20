using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int MaxDepth(string s)
        {
            int max = 0;
            int count = 0;
            
            foreach (char c in s)
            {
                if (c == '(')
                {
                    count++;
                    continue;
                }

                if (c == ')')
                {
                    max = Math.Max(max, count);
                    count--;
                    continue;
                }                
            }

            return max;
        }
    }
}
