using System.Collections;

public class Solution 
{
    public int SecondHighest(string s) 
    {
        // o(n) - time, o(1) - space
        var bitArray = new BitArray(10);

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                bitArray.Set(s[i] - '0', true);
            }
        }

        bool flagFirst = false;
        for (int i = 9; i >= 0; i--)
        {
            if (bitArray.Get(i))
            {
                if (flagFirst) return i;

                flagFirst = true;
            }
        }

        return -1;
    }
}