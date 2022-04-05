using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        // O(n) time O(n) space
        public int MinAddToMakeValid_FirstAttempt(string s)
        {
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == ')' && stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }                
            }

            return stack.Count;
        }

        public int MinAddToMakeValid(string s)
        {

            int result = 0, balance = 0;
            foreach (char c in s)
            {
                if (c == '(')
                {
                    balance++;
                }
                else
                {
                    balance--;
                }

                if (balance == -1)
                {
                    result++;
                    balance++;
                }

            }

            return result + balance;
        }
    }
}
