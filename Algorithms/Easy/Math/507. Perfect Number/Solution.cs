public class Solution {
    public bool CheckPerfectNumber(int num) 
    {
        return BruteForceOptimized(num);       
    }

    private bool BruteForceOptimized(int num)
    {
        int sum = 0;
        int secondDivisor = 1;
        for (int i = 1; i <= num / secondDivisor; i++)
        {
            if (IsDivisor(num, i))
            {
                if (i != 1 && secondDivisor == 1)
                {
                    secondDivisor = i;
                }

                sum += i;
            }
        }

        return sum == num && num != 1;
    }

    private bool IsDivisor(int num, int i)
    {
        double d = (double)num / i;
        double f = Math.Floor(d);
        return (d - f < double.Epsilon);
    }
}