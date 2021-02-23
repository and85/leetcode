using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool RotateString(string a, string b)
        {
            if (a?.Length != b?.Length)
                return false;

            if (string.IsNullOrWhiteSpace(a) && string.IsNullOrWhiteSpace(b))
                return true;

            var sb = new StringBuilder(a);
            char fc;
            for (int i = 0; i < a.Length; i++)
            {
                fc = sb[0];                
                sb.Remove(0, 1);
                sb.Append(fc);

                if (sb.Equals(b))
                    return true;
            }

            return false;
        }

    }
}
