using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        // http://www.wisenheimerbrainstorm.com/archive/algorithms/dijkstra-s-two-stack-algorithm
        public int Calculate(string s)
        {
            s = s.Replace(" ", string.Empty);
            EvaluateExpression(s);

            return 0;
        }

        private static void EvaluateExpression(string s)
        {
            var operators = new Stack<string>();
            var values = new Stack<int>();
        }
    }
}
