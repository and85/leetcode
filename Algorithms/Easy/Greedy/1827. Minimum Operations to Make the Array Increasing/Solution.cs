public class Solution {
    public int MinOperations(int[] nums) {
        if (nums.Length <= 1) return 0;

        int result = 0, diff;
        for (int i = 1; i < nums.Length; i++)
        {
            diff = nums[i] - nums[i - 1];
            if (diff <= 0) 
            {
                nums[i] = nums[i - 1] + 1;
                result += Math.Abs(diff) + 1;
            }
        
        }

        return result;
    }
}