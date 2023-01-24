using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution_attemp1
    {
        public string RemoveOuterParentheses(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s;

            var sb = new StringBuilder();
            var buffer = new Stack<char>();

            foreach (char ch in s)
            {
                if (!(buffer.Count == 0 || buffer.Count == 1 && ch == ')'))
                    sb.Append(ch);

                if (ch == '(')
                    buffer.Push('(');
                else
                    buffer.Pop();
            }

            return sb.ToString();
        }
    }
}
