using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        // taken from the solution and slightly refactored
        public IList<string> RemoveComments(string[] source)
        {
            bool inCommentBlock = false;
            StringBuilder newline = new StringBuilder();
            
            List<string> result = new List<string>();

            foreach (string line in source)
            {
                int i = 0;
                char[] chars = line.ToCharArray();
                if (!inCommentBlock) newline = new StringBuilder();
                while (i < line.Length)
                {
                    if (!inCommentBlock && !EndOfLine(line, i) && MultipleLineCommentOpen(chars, i))
                    {
                        inCommentBlock = true;
                        i++;
                    }
                    else if (inCommentBlock && !EndOfLine(line, i) && MultipleLineCommentClose(chars, i))
                    {
                        inCommentBlock = false;
                        i++;
                    }
                    else if (!inCommentBlock && !EndOfLine(line, i) && SingleLineComment(chars, i))
                    {
                        break;
                    }
                    else if (!inCommentBlock)
                    {
                        newline.Append(chars[i]);
                    }
                    i++;
                }
                if (!inCommentBlock && newline.Length > 0)
                {
                    result.Add(newline.ToString());
                }
            }
            return result;
        }

        private bool EndOfLine(string line, int index)
        {
            return index + 1 >= line.Length;
        }

        private bool MultipleLineCommentOpen(char[] chars, int i)
        {
            return chars[i] == '/' && chars[i + 1] == '*';
        }

        private bool MultipleLineCommentClose(char[] chars, int i)
        {
            return chars[i] == '*' && chars[i + 1] == '/';
        }

        private bool SingleLineComment(char[] chars, int i)
        {
            return chars[i] == '/' && chars[i + 1] == '/';
        }
    }
}
