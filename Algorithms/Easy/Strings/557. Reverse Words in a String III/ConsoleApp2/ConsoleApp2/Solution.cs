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
            var sb = new StringBuilder();

            int p1 = 0, p2 = 0;
            while (p2 <= s.Length)
            {
                if (p2 == s.Length || s[p2] == ' ')
                {
                    sb.Append(ReversePart(s, p1, p2 - 1)).Append(' ');
                    p1 = p2 + 1;
                }

                p2++;
            }

            return sb.ToString().Trim();
        }

        private string ReversePart(string s, int p1, int p2)
        {
            char[] arr = s.Substring(p1, p2 - p1 + 1).ToCharArray();

            /*p1 = 0; 
            p2 = arr.Length - 1;
            char t;
            while (p1 < p2)
            {
                t = arr[p1];
                arr[p1] = arr[p2];
                arr[p2] = t;
                
                p1++;
                p2--;
            }*/            
            Array.Reverse(arr);

            return new string(arr);
        }

        public string ReverseWords_AAttempt1(string s)
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
