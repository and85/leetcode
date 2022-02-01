public class Solution
{
    public int CountElements(int[] nums)
    {
        var result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            result += HasBoth(nums, nums[i]) ? 1 : 0;
        }

        return result;
    }

    private bool HasBoth(int[] nums, int v)
    {
        return HasSmaller(nums, v) && HasGreater(nums, v);
    }

    private bool HasGreater(int[] nums, int v)
    {
        return nums.Any(n => n > v);
    }

    private bool HasSmaller(int[] nums, int v)
    {
        return nums.Any(n => n < v);
    }
}