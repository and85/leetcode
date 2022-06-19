public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1, m;

        while (l <= r)
        {
            m = l + (r - l) / 2;

            if (nums[m] == target) return m;

            if (nums[m] < target)
            {
                l = m + 1;
            }
            else if (nums[m] > target)
            {
                r = m - 1;
            }            
        }

        return l;
        //return l < nums.Length && target > nums[l] ? l + 1 : l;

    }
}