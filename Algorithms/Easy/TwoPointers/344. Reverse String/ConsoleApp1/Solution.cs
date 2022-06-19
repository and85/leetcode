public class Solution {

    public void ReverseString(char[] s)
    {
        int l = 0, r = s.Length - 1;

        while (l < r)
        {
            char t = s[l];
            s[l] = s[r];
            s[r] = t;

            l++;
            r--;
        }
    }

    public void ReverseString_Attempt1(char[] s) 
    {
        // "h", "e", "l", "l", "o"    
        int l = 0, r = s.Length - 1;

        char t;
        while (l < r)
        {
            t = s[l];
            s[l++] = s[r];
            s[r--] = t;
        }
    }
}