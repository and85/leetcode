public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        int order = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (order == 0)
            {
                order = nums[i] - nums[i + 1];
            }
            else if (nums[i] - nums[i + 1] < 0 && order > 0)
            {
                return false;
            }
            else if (nums[i] - nums[i + 1] > 0 && order < 0)
            {
                return false;
            }
        }

        return true;
    }
}