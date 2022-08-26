public class Solution
{
    public bool IsHappy(int n)
    {
        var seen = new HashSet<int>();
        seen.Add(n);

        while (n != 1)
        {
            n = GetNextMutation(n);
            if (seen.Contains(n)) return false;
            seen.Add(n);
        }

        return true;
    }

    private int GetNextMutation(int n)
    {
        int result = 0;

        while (n != 0)
        {
            result += (int)Math.Pow(n % 10, 2);
            n = n / 10;
        }
        

        return result;
    }
}