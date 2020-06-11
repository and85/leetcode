using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private const char RemovedChar = '0';

        public int Compress(char[] chars)
        {
            int anchor = 0, write = 0;
            for (int read = 0; read < chars.Length; read++)
            {
                if (read + 1 == chars.Length || chars[read + 1] != chars[read])
                {
                    chars[write++] = chars[anchor];
                    if (read > anchor)
                    {
                        foreach (char c in ("" + (read - anchor + 1)).ToCharArray())
                        {
                            chars[write++] = c;
                        }
                    }
                    anchor = read + 1;
                }
            }
            return write;
        }
    }
}
