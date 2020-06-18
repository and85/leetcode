using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            int currValue, currDigit, carry = 0;
            string aDigit, bDigit;

            int i = a.Length - 1;
            int j = b.Length - 1;

            StringBuilder revertedResult = new StringBuilder();
            while (i >=0 || j >= 0)
            {
                aDigit = (i >= 0) ? a[i].ToString() : "0";
                bDigit = (j >= 0) ? b[j].ToString() : "0";

                currValue = Convert.ToInt32(aDigit) + Convert.ToInt32(bDigit) + carry;

                currDigit = currValue % 2;
                carry = currValue / 2;

                revertedResult.Append(currDigit);

                i--;
                j--;
            }

            if (carry == 1)
                revertedResult.Append(1);

            var arr = revertedResult.ToString().ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }
    }
}
