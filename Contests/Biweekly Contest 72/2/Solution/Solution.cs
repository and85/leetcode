public class Solution
{
    public long[] SumOfThree(long num)
    {
        if (num % 3 == 0)
        {
            return new long[] { num / 3 - 1, num / 3, num / 3 + 1 };
        }

        return new long[0];
    }
}