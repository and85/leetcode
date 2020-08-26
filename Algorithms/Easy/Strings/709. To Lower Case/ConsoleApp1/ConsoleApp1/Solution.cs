using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string ToLowerCase(string str)
        {
            var result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                int index = str[i];
                if (index >= 65 && index <= 90)
                    result.Append(Convert.ToChar(index + 32));
                else
                    result.Append(str[i]);
            }
                
            return result.ToString();
        }
    }
}
