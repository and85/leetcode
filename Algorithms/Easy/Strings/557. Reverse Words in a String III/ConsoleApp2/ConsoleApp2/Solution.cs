using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            var resultSb = new StringBuilder(s.Length);
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    AppendResult(resultSb, stack);
                    resultSb.Append(' ');
                }
            }

            // last word of the sentence which may not contain spaces after it
            AppendResult(resultSb, stack);

            return resultSb.ToString();
        }

        private static void AppendResult(StringBuilder resultSb, Stack<char> stack)
        {
            while (stack.Count != 0)
            {
                resultSb.Append(stack.Pop());
            }
        }
    }
}
