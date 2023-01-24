public class Solution 
{
    public IList<int> FindDuplicates(int[] nums) 
    {
        var result = new List<int>();        
        
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;

            if (nums[index] < 0)
            {
                result.Add(index + 1);
            }
            else
            {
                nums[index] = -nums[index];
            }
        }

        return result;
    }

    public IList<int> FindDuplicates_Naive(int[] nums) 
    {
        var result = new List<int>();
        int[] memo = new int[100000];
        
        for (int i = 0; i < nums.Length; i++)
        {            
            if (memo[nums[i]] == 0)
            {
                memo[nums[i]] = 1;
            }
            else
            {
                result.Add(nums[i]);
            }
        }

        return result;
    }
}