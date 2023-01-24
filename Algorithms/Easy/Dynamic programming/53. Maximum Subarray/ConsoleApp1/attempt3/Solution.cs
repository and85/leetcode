public class Solution 
{
    public int MaxSubArray(int[] nums)
    {
        int maxSum = int.MinValue, curSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < curSum + nums[i])
            {
                curSum += nums[i];
            }
            else
            {
                curSum = nums[i];
            }

            maxSum = Math.Max(maxSum, curSum);
        }

        return maxSum;
    }
}