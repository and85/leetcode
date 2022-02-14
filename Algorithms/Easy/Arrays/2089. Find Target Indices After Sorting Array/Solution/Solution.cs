public class Solution 
{
    // O(n) time
    public IList<int> TargetIndices(int[] nums, int target)
    {        
        int smallerCounter = nums.Count(n => n < target);
        int targetCounter = nums.Count(n => n == target);        

        return Enumerable.Range(smallerCounter, targetCounter).ToList();
    }
}