public class Solution
{
    public bool IsUgly(int n)
    {
        if ((n % 4 == 0 && n != 4) ||
            (n % 6 == 0 && n != 6) ||
            (n % 7 == 0 && n != 7) ||
            (n % 8 == 0 && n != 8) ||
            (n % 9 == 0 && n != 9))
        {
            return false;
        }

        return true;
    }
}