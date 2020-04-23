using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Solution
    {
        char[] _openBrackets = new char[3] { '(', '{', '[' };
        char[] _closedBrackets = new char[3] { ')', '}', ']' };
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            var openBracketsStack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char cur = s[i];
                
                if (Array.Exists(_openBrackets, el => el == cur))
                    openBracketsStack.Push(cur);
                else
                {
                    // closed brackets
                    if (openBracketsStack.Count == 0)
                        return false;

                    char openBracket = openBracketsStack.Pop();

                    int openIndex = Array.IndexOf(_openBrackets, openBracket);
                    int closeIndex = Array.IndexOf(_closedBrackets, cur);

                    if (openIndex != closeIndex)
                        return false;
                }
            }

            return (openBracketsStack.Count == 0);
        }
    }
}
