using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // https://leetcode.com/problems/evaluate-reverse-polish-notation/
    public class Solution
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> numbers = new Stack<int>();
            foreach (string token in tokens)
            {
                if (new List<string>() { "+", "-", "*", "/" }.Contains(token))
                {
                    int right = numbers.Pop();
                    int left = numbers.Pop();

                    switch (token)
                    {
                        case "+":
                            numbers.Push(left + right);
                            break;
                        case "-":
                            numbers.Push(left - right);
                            break;
                        case "*":
                            numbers.Push(left * right);
                            break;
                        case "/":
                            numbers.Push(left / right);
                            break;
                    }
                }
                else
                    numbers.Push(int.Parse(token));
            }

            return numbers.Peek();
        }
    }
}
