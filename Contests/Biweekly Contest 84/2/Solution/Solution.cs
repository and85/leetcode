public class Solution 
{
    public long CountBadPairs(int[] nums) 
    {
        int res = 0;

        int n = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] != 1)
            {
                
                if (n == 0) 
                {
                    n = 1;
                }
                n++;
            }
            else
            {
                res += n * (n + 1) / 2;

                n = 0;
            }
        }
        

        res += n * (n + 1) / 2;

        return res / 2;
    }
}