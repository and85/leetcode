using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string DefangIPaddr(string address)
        {
            // obviously this one also would work, but it's not the point of the problem
            // return adress.Replace(".", "[.]");

            var result = new StringBuilder(address.Length + 6);

            int r = 0;
            foreach (var c in address)
            {
                if (c == '.')
                {
                    result.Append("[.]");
                    continue;
                }

                result.Append(c);
            }

            return result.ToString();
        }
    }
}
