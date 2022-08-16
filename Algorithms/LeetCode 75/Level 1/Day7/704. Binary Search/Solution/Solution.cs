public class Solution
{
    public int Search(int[] nums, int target)
    {
        //return Iterative(nums, target);
        return Recursive(nums, target, 0, nums.Length - 1);
    }

    private static int Recursive(int[] nums, int target, int l, int r)
    {
        if (l <= r)
        {
            int m = l + (r - l) / 2;
        
            if (nums[m] == target) return m;

            if (nums[m] < target)
            {
                return Recursive(nums, target, m + 1, r);
            }
            else
            {
                return Recursive(nums, target, l, m - 1);
            }
        }

        return -1;
    }

    private static int Iterative(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;

        while (l <= r)
        {
            int m = l + (r - l) / 2;

            if (nums[m] == target) return m;
            if (nums[m] < target)
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return -1;
    }
}