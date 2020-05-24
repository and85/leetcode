using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool BackspaceCompare(string S, string T)
        {
            var sStack = new Stack<char>();
            var tStack = new Stack<char>();
            
            PopulateStack(S, sStack);
            PopulateStack(T, tStack);

            if (sStack.Count != tStack.Count)
                return false;

            while (sStack.Count != 0)
            {
                if (sStack.Pop() != tStack.Pop())
                    return false;
            }

            sStack.ToString

            return true;
        }

        private static void PopulateStack(string str, Stack<char> stack)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '#')
                    stack.Push(str[i]);
                else
                    stack.TryPop(out char _);
            }
        }
    }
}
