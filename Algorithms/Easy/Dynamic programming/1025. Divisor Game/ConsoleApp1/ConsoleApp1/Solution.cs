using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {

        Dictionary<int, bool> _memo = new Dictionary<int, bool>();

        public bool DivisorGame(int N)
        {
            return N % 2 == 0;
        }
    }
}
