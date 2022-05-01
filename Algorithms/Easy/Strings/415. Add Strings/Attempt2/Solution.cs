using System;
using System.Text;

public class Solution 
{
    public string AddStrings(string num1, string num2) 
    {
        StringBuilder sb = new StringBuilder();

        int carry = 0;
        for (int k = 0; k < Math.Min(num1.Length, num2.Length); k++)
        {
            int i = num1.Length - k - 1;
            int j = num2.Length - k - 1;

            int d1 = (i >= 0) ? (nums[i] - '0') : 0;
            int d2 = (j >= 0) ? (nums[j] - '0') : 0;

            int d = (d1 + d2 + carry) % 10;
            carry = (d1 + d2) / 10;

            sb.Append(d);
        }
    }
}