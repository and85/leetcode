public class Solution 
{
    public long ZeroFilledSubarray(int[] nums) 
    {
        long result = 0;
        long curWindow = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                result += curWindow * (curWindow + 1) / 2;
                curWindow = 0;
            }
            else
            {
                curWindow++;
            }
        }

        result += curWindow * (curWindow + 1) / 2;

        return result;
    }
}