using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return string.Empty;

            if (strs.Length == 1)
                return strs[0];

            StringBuilder prefix = new StringBuilder();
            int shortestLenght = strs.Min(s => s.Length);

            for (int i = 0; i < shortestLenght; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j - 1][i] != strs[j][i])
                    {
                        goto exit;
                    }
                }

                prefix.Append(strs[0][i]);
            }

            exit:
            return prefix.ToString();
        }
    }
}
