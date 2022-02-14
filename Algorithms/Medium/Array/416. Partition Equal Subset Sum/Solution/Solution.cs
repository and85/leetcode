public class Solution
{
    public bool CanPartition(int[] nums)
    {        
        int totalSum = nums.Sum();

        if (totalSum % 2 != 0)
        {
            return false;
        }        

        int halfSum = totalSum / 2;

        for (int i = 0; i < nums.Length; i++)
        {
            if (CanFormSum(nums, new HashSet<int>() { i }, halfSum)) 
            {
                return true;
            }
        }

        return false;
    }

    private bool CanFormSum(int[] nums, HashSet<int> onePartIndexes, int targetSum)
    {        
        int curSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (onePartIndexes.Contains(i))
            {
                continue;
            }

            curSum += nums[i];

            if (curSum == targetSum)
            {
                return true;
            }

            var cloned = new HashSet<int>(onePartIndexes);
            cloned.Add(i);
            if (CanFormSum(nums, cloned, targetSum - nums[i]))
            {
                return true;
            }
        }    

        return false;
    }
}