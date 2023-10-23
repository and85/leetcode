using System.Text;

public class Solution
{
    public static bool FindPrime(int number)  
    {
        if (number <= 1) return true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }

        return true;  
    }   
}