using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string RemoveOuterParentheses(string s)
        {
            var sb = new StringBuilder();

            // "(()()) (()) (()(()))"
            int opened = 0;
            bool groupStarted = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    if (opened != 0)
                    {
                        sb.Append('(');
                    }

                    opened++;
                }
                else
                {
                    if (opened != 1)
                    {
                        sb.Append(')');
                    }

                    opened--;
                }
            }

            return sb.ToString();

        }
    }
}
