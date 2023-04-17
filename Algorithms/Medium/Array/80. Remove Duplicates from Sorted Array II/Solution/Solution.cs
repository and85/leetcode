public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        int r = 2, w = 2;

        while (r < nums.Length)
        {
            if (nums[r] == nums[r - 1] && nums[r] == nums[r - 2])
            {
                r++;
                continue;
            }

            nums[w] = nums[r];
            w++;
            r++;
        }

        return w;
    }
} 