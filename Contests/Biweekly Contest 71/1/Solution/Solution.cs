using System;

public class Solution
{
    public int MinimumSum(int num)
    {
        var digits = num.ToString().ToCharArray();
        Array.Sort(digits);

        return (Convert.ToInt32(digits[0] - '0') + Convert.ToInt32(digits[1] - '0')) * 10 + (Convert.ToInt32(digits[2] - '0') + Convert.ToInt32(digits[3] - '0'));        
    }
}