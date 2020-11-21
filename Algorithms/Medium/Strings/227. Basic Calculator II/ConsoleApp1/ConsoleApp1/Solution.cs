using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int Calculate(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            s = s.Replace(" ", string.Empty);

            var stack = new Stack<int>();
            int currentNumber = 0;
            char operation = '+';
            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                if (char.IsDigit(currentChar))
                {
                    currentNumber = (currentNumber * 10) + (currentChar - '0');
                }
                if (!char.IsDigit(currentChar) || i == s.Length - 1)
                {
                    if (operation == '-')
                    {
                        stack.Push(-currentNumber);
                    }
                    else if (operation == '+')
                    {
                        stack.Push(currentNumber);
                    }
                    else if (operation == '*')
                    {
                        stack.Push(stack.Pop() * currentNumber);
                    }
                    else if (operation == '/')
                    {
                        stack.Push(stack.Pop() / currentNumber);
                    }
                    operation = currentChar;
                    currentNumber = 0;
                }
            }
            int result = 0;
            while (stack.Count > 0)
                result += stack.Pop();

            return result;

        }
    }
}
